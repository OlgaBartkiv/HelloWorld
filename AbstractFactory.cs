using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HelloWorld
{
    public abstract class IHomeDevicesFactory
    {
        public abstract IHomeDevice GetDevice(string deviceType);
        public static IHomeDevicesFactory CreateIHomeDevicesFactory(string factoryType)
        {
            if (factoryType.Equals("Kitchen"))
                return new KitchenDevicesFactory();
            else
                return new CleaningDevicesFactory();
        }

        public class KitchenDevicesFactory : IHomeDevicesFactory
        {
            public override IHomeDevice GetDevice(string deviceType)
            {
                if (deviceType.Equals("Kettle"))
                {
                    return new Kettle();
                }
                else if (deviceType.Equals("Toaster"))
                {
                    return new Toaster();
                }
                else if (deviceType.Equals("Microwave oven"))
                {
                    return new MicrowaveOven();
                }
                else
                    return null;
            }
        }

        public class CleaningDevicesFactory : IHomeDevicesFactory
        {
            public override IHomeDevice GetDevice(string deviceType)
            {
                if (deviceType.Equals("Hoover"))
                {
                    return new Hoover(new Toaster());
                }
                else if (deviceType.Equals("Washing machine"))
                {
                    return new WashingMachine(new MicrowaveOven());
                }
                else
                    return null;
            }
        }

        public interface IHomeDevice
        {
            string Feature();
        }

        public class Kettle : IHomeDevice
        {
            public string Feature()
            {
                return "boiling water";
            }
        }
        public class Toaster : IHomeDevice
        {
            public string Feature()
            {
                return "toasting bread";
            }
        }
        public class MicrowaveOven : IHomeDevice
        {
            public string Feature()
            {
                return "warming up food";
            }
        }
        public class Hoover : IHomeDevice
        {
            public Hoover(IHomeDevice homeDevice)
            {
                Debug.WriteLine(homeDevice.Feature());
            }
            public string Feature()
            {
                return "removing dirt from floor";
            }
        }
        public class WashingMachine : IHomeDevice
        {
            public WashingMachine(IHomeDevice homeDevice)
            {
                Debug.WriteLine(homeDevice.Feature());
            }
            public string Feature()
            {
                return "washing laundry";
            }
        }
    }
}
