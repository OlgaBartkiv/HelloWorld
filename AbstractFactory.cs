using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public abstract class HomeDevicesFactory
    {
        public abstract HomeDevice GetDevice(string deviceType);
        public static HomeDevicesFactory CreateHomeDevicesFactory(string factoryType)
        {
            if (factoryType.Equals("Kitchen"))
                return new KitchenDevicesFactory();
            else
                return new CleaningDevicesFactory();
        }

        public class KitchenDevicesFactory : HomeDevicesFactory
        {
            public override HomeDevice GetDevice(string deviceType)
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

        public class CleaningDevicesFactory : HomeDevicesFactory
        {
            public override HomeDevice GetDevice(string deviceType)
            {
                if (deviceType.Equals("Hoover"))
                {
                    return new Hoover();
                }
                else if (deviceType.Equals("Washing machine"))
                {
                    return new WashingMachine();
                }
                else
                    return null;
            }
        }

        public interface HomeDevice
        {
            string feature();
        }

        public class Kettle : HomeDevice
        {
            public string feature()
            {
                return "boiling water";
            }
        }
        public class Toaster : HomeDevice
        {
            public string feature()
            {
                return "toasting bread";
            }
        }
        public class MicrowaveOven : HomeDevice
        {
            public string feature()
            {
                return "warming up food";
            }
        }
        public class Hoover : HomeDevice
        {
            public string feature()
            {
                return "removing dirt from floor";
            }
        }
        public class WashingMachine : HomeDevice
        {
            public string feature()
            {
                return "washing laundry";
            }
        }
    }
}
