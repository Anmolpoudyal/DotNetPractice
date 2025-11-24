using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5
{
    public class Laptop : ElectronicDevice
    {
        public Laptop(string brand, double price) : base(brand, price) { }

        // Extra method
        public void TurnOnBattery()
        {
            Console.WriteLine($"{Brand} laptop battery is turned on");
        }

        // Override ShowInfo
        public override void ShowInfo()
        {
            Console.WriteLine($"Laptop Brand: {Brand}");
            Console.WriteLine($"Price: ${Price}");
        }
    }
}
