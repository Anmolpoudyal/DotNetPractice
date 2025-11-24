using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5
{
    public class Vehicle
    {
        // Properties
        public string Brand { get; set; }
        public int Speed { get; set; }

        // Constructor
        public Vehicle(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }

        // Methods
        public void Start()
        {
            Console.WriteLine($"{Brand} is starting.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} has stopped.");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Vehicle Brand: {Brand}");
            Console.WriteLine($"Vehicle Speed: {Speed} km/h");
        }



    }
}
