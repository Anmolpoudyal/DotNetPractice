using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5
{
    // ElectronicsStore class
    public class ElectronicsStore
    {
        // List to store devices
        private List<ElectronicDevice> devices = new List<ElectronicDevice>();

        // Add device
        public void AddDevice(ElectronicDevice device)
        {
            devices.Add(device);
            Console.WriteLine($"{device.Brand} added to the store.");
        }

        // Remove device
        public void RemoveDevice(ElectronicDevice device)
        {
            if (devices.Remove(device))
            {
                Console.WriteLine($"{device.Brand} removed from the store.");
            }
            else
            {
                Console.WriteLine($"{device.Brand} not found in the store.");
            }
        }

        // Show details of all devices
        public void ShowAllDeviceDetails()
        {
            Console.WriteLine("\n--- All Devices in Store ---");
            foreach (var device in devices)
            {
                device.ShowInfo();

                // Downcasting to call child-specific methods
                if (device is Laptop laptop)
                {
                    laptop.TurnOnBattery();
                }
                else if (device is Smartphone phone)
                {
                    phone.EnableCamera();
                }

                Console.WriteLine();
            }
        }
    }

}
