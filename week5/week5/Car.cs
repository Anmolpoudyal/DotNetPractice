using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace week5
{
    public class Car : Vehicle
    {
        public int Seats { get; set; }

        public Car(string brand, int speed, int seats) : base(brand, speed)
        {
            Seats = seats;
        }

        // Override DisplayInfo to include unique field
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Number of Seats: {Seats}");
        }
    }

}
