using Prototype.Components;
using Prototype.Devices;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Prototype
{
    class Program
    {
        static Dictionary<string, Device> devices =
            new Dictionary<string, Device>
            ( new KeyValuePair<string, Device>[]
                {
                    new KeyValuePair<string, Device>("desktop",new Desktop()),
                    new KeyValuePair<string, Device>("laptop",new Laptop()),
                    new KeyValuePair<string, Device>("notebook",new Notebook()),
                    new KeyValuePair<string, Device>("tablet",new Tablet()),
                }
            );
        static void Main(string[] args)
        {
            Console.WriteLine("Prototypes:\n ");
            foreach(Device device in devices.Values)
            {
                Console.WriteLine("Device {0} with components:", device.GetType().Name);
                device.ShowInfo();
                Console.WriteLine();
            }

           

            Laptop laptop = (Laptop)devices["laptop"].Clone();
            Desktop desktop = (Desktop)devices["desktop"].Clone();
            laptop.components.Add(new Mouse("new mouse"));
            desktop.components.Add(new Keyboard("new key borad"));

            Console.WriteLine("--AFTER CLONNING DEVICES--");
            Console.WriteLine("Prototypes:\n ");
            foreach (Device device in devices.Values)
            {
                Console.WriteLine("Device {0} with components:", device.GetType().Name);
                device.ShowInfo();
                Console.WriteLine();
            }
            Console.WriteLine("New devices:\n ");
            Console.WriteLine("Device {0} with components:", laptop.GetType().Name);
            laptop.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("Device {0} with components:", desktop.GetType().Name);
            desktop.ShowInfo();
        }
    }
}
