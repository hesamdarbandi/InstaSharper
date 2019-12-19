using System;
using System.Collections.Generic;
using System.Linq;
using InstaSharper.Helpers;

namespace InstaSharper.Classes.Android.DeviceInfo
{
    public class AndroidDeviceGenerator
    {
        private static readonly List<string> DevicesNames = new List<string>
        {
            AndroidDevices.SAMSUNG_GALAXY_S7,
            AndroidDevices.HUAWEI_MATE_9_PRO,
            AndroidDevices.samsung_galaxy_s7_edg,
            AndroidDevices.lg_g5,
            AndroidDevices.one_plus_3t,
            AndroidDevices.one_plus_7,
            AndroidDevices.samsung_galaxy_s9_plus,
            AndroidDevices.zte_axon_7

        };

        public static Dictionary<string, AndroidDevice> AndroidAndroidDeviceSets =
            new Dictionary<string, AndroidDevice>
            {
                {
                    "samsung_galaxy_s7",
                    new AndroidDevice
                    {
                        InstagramVersion = "26.0.0.10.86",
                        AndroidVersion = 24,
                        AndroidRelease = "7.0",
                        Dpi = "640dpi",
                        Resolution = "1440x2560",
                        Manufacturer = "samsung",
                        Device = "SM-G930F",
                        Model = "herolte",
                        Cpu = "samsungexynos8890",
                        DeviceGuid = HttpHelper.GenUuid(),
                        PhoneGuid =  HttpHelper.GenUuid()
                    }
                },
                {
                    "samsung_galaxy_s7_edge",
                    new AndroidDevice
                    {
                        InstagramVersion = "26.0.0.10.86",
                        AndroidVersion = 23,
                        AndroidRelease = "6.0.1",
                        Dpi = "640dpi",
                        Resolution = "1440x2560",
                        Manufacturer = "samsung",
                        Device = "SM-G935",
                        Model = "hero2lte",
                        Cpu = "samsungexynos8890",
                        DeviceGuid = HttpHelper.GenUuid(),
                        PhoneGuid =  HttpHelper.GenUuid()
                    }
                },
                {
                    "huawei_mate_9_pro",
                    new AndroidDevice
                    {
                        InstagramVersion = "26.0.0.10.86",
                        AndroidVersion = 24,
                        AndroidRelease = "7.0",
                        Dpi = "640dpi",
                        Resolution = "1440x2560",
                        Manufacturer = "HUAWEI",
                        Device = "LON-L29",
                        Model = "HWLON",
                        Cpu = "hi3660",
                        DeviceGuid =HttpHelper.GenUuid(),
                        PhoneGuid = HttpHelper.GenUuid()
                    }
                },
               {
                    "one_plus_7",
                    new AndroidDevice
                    {
                        InstagramVersion = "26.0.0.10.86",
                        AndroidVersion = 28,
                        AndroidRelease = "9.0",
                        Dpi = "420dpi",
                        Resolution = "1080x2260",
                        Manufacturer = "OnePlus",
                        Device = "GM1903",
                        Model = "OnePlus7",
                        Cpu = "qcom",
                        DeviceGuid =HttpHelper.GenUuid(),
                        PhoneGuid = HttpHelper.GenUuid()
                    }
                },
                {
                    "samsung_galaxy_s9_plus",
                    new AndroidDevice
                    {
                        InstagramVersion = "26.0.0.10.86",
                        AndroidVersion = 24,
                        AndroidRelease = "7.0",
                        Dpi = "640dpi",
                        Resolution = "1440x2560",
                        Manufacturer = "samsung",
                        Device = "SM-G965F",
                        Model = "star2qltecs",
                        Cpu = "samsungexynos9810",
                        DeviceGuid =HttpHelper.GenUuid(),
                        PhoneGuid = HttpHelper.GenUuid()
                    }
                },
                {
                    "one_plus_3t",
                    new AndroidDevice
                    {
                        InstagramVersion = "26.0.0.10.86",
                        AndroidVersion = 28,
                        AndroidRelease = "9.0",
                        Dpi = "380dpi",
                        Resolution = "1080x1920",
                        Manufacturer = "OnePlus",
                        Device = "ONEPLUS A3010",
                        Model = "OnePlus3T",
                        Cpu = "qcom",
                        DeviceGuid =HttpHelper.GenUuid(),
                        PhoneGuid = HttpHelper.GenUuid()
                    }
                },
                {
                    "lg_g5",
                    new AndroidDevice
                    {
                        InstagramVersion = "26.0.0.10.86",
                        AndroidVersion = 23,
                        AndroidRelease = "6.0.1",
                        Dpi = "640dpi",
                        Resolution = "1440x2392",
                        Manufacturer = "LGE/lge",
                        Device = "RS988",
                        Model = "h1",
                        Cpu = "h1",
                        DeviceGuid =HttpHelper.GenUuid(),
                        PhoneGuid = HttpHelper.GenUuid()
                    }
                },
                  {
                    "zte_axon_7",
                    new AndroidDevice
                    {
                        InstagramVersion = "26.0.0.10.86",
                        AndroidVersion = 23,
                        AndroidRelease = "6.0.1",
                        Dpi = "640dpi",
                        Resolution = "1440x2560",
                        Manufacturer = "ZTE",
                        Device = "ZTE A2017U",
                        Model = "ailsa_ii",
                        Cpu = "qcom",
                        DeviceGuid =HttpHelper.GenUuid(),
                        PhoneGuid = HttpHelper.GenUuid()
                    }
                }

            };

        public static AndroidDevice GetRandomAndroidDevice()
        {
            var random = new Random(DateTime.Now.Millisecond);
            var randmonDeviceIndex = random.Next(0, DevicesNames.Count);
            var randomDeviceName = DevicesNames[randmonDeviceIndex];
            return AndroidAndroidDeviceSets[randomDeviceName];
        }

        public static AndroidDevice GetByName(string name)
        {
            return AndroidAndroidDeviceSets[name];
        }

        public static AndroidDevice GetById(string deviceId)
        {
            return (from androidAndroidDeviceSet in AndroidAndroidDeviceSets
                    where androidAndroidDeviceSet.Value.DeviceId == deviceId
                    select androidAndroidDeviceSet.Value).FirstOrDefault();
        }
    }
}