using NAudio.CoreAudioApi;
using System;

namespace Microphone
{
	/// <summary>
	/// Allows for the manipulation of a given microphone device.
	/// </summary>
	public class Mic
	{
		private readonly MMDevice micDevice;

		/// <summary>
		/// Creates a new <see cref="Microphone"/> object to access a specific microphone.
		/// </summary>
		/// <param name="MicIndex">The 0-based index position of the microphone device to access from the list of microphone devices.</param>
		public Mic(int MicIndex)
		{
			MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
			MMDeviceCollection devices = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
			if (devices.Count > 0)
			{
				if (MicIndex <= devices.Count - 1 || MicIndex >= 0)
				{
					micDevice = devices[MicIndex];
				}
				else throw new ArgumentOutOfRangeException("MicIndex", "The index position was outside the bounds of the array.");
			}
			else throw new Exception("Unable to retrieve microphone device(s) because there are no devices to retrieve.");
		}

		/// <summary>
		/// Creates a new <see cref="Microphone"/> object to access a specific microphone.
		/// </summary>
		/// <param name="DeviceName">Can either be the full name, basic name, or a substring of your microphone's device name.</param>
		public Mic(string DeviceName)
		{
			MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
			MMDeviceCollection devices = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
			if (devices.Count > 0)
			{
				foreach (MMDevice device in devices)
				{
					if (device.FriendlyName.Contains(DeviceName))
					{
						micDevice = device;
					}
					else throw new ArgumentException("No microphones similar to, or containing, the name '" + DeviceName + "' were found.", "DeviceName");
				}
			}
			else throw new Exception("Unable to retrieve microphone device(s) because there are no devices to retrieve.");
		}

		/// <summary>
		/// The audio device that represents the current <strong>microphone</strong>.
		/// </summary>
		public MMDevice Device => micDevice;

		/// <summary>
		/// The full name of the device.
		/// </summary>
		public string Name => micDevice.FriendlyName;

		/// <summary>
		/// The basic name of the device.
		/// </summary>
		public string FriendlyName => micDevice.DeviceFriendlyName;

		/// <summary>
		/// The volume (in whole numbers only) of the microphone.
		/// </summary>
		public int Volume
		{
			get { return (int)(micDevice.AudioEndpointVolume.MasterVolumeLevelScalar * 100); }
			set { micDevice.AudioEndpointVolume.MasterVolumeLevelScalar = value / 100.0f; }
		}

		/// <summary>
		/// The volume (including decimals) of the microphone.
		/// </summary>
		public float VolumeF
		{
			get { return micDevice.AudioEndpointVolume.MasterVolumeLevelScalar; }
			set
			{
				if (value > 1)
				{
					value = 1.0f;
				}
				else if (value < 0)
				{
					value = 0.0f;
				}
				else
				{
					if (value.ToString().Length > 4)
					{
						string num = value.ToString();
						num = num.Remove(4);
						num += "f";
						value = float.Parse(num);
					}
				}

				micDevice.AudioEndpointVolume.MasterVolumeLevelScalar = value;
			}
		}
	}
}
