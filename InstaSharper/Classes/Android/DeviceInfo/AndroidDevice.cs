using System;

namespace InstaSharper.Classes.Android.DeviceInfo
{
    [Serializable]
    public class AndroidDevice
    {
        public Guid PhoneGuid { get; set; }
        public Guid DeviceGuid { get; set; }
        public Guid GoogleAdId { get; set; } = Guid.NewGuid();
        public Guid RankToken { get; set; } = Guid.NewGuid();
        public string InstagramVersion { get; set; }
        public int AndroidVersion { get; set; }
        public string AndroidRelease { get; set; }
        public string Dpi { get; set; }
        public string Resolution { get; set; }
        public string Manufacturer { get; set; }
        public string Device { get; set; }
        public string Model { get; set; }
        public string Cpu { get; set; }
        public string DeviceId { get; set; }
        public string FirmwareFingerprint { get; set; }

    }
}