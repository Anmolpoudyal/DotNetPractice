using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5
{
    // Derived class: Smartphone
    public class Smartphone : ElectronicDevice
    {
        public Smartphone(string brand, double price) : base(brand, price) { }

        // Extra method
        public void EnableCamera()
        {
            Console.WriteLine($"{Brand} smartphone camera is enabled");
        }

        // Override ShowInfo
        public override void ShowInfo()
        {
            Console.WriteLine($"Smartphone Brand: {Brand}");
            Console.WriteLine($"Price: ${Price}");
        }
    }
}
