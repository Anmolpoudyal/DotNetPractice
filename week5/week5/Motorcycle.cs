using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5
{
    // Derived class Motorcycle
    public class Motorcycle : Vehicle
    {
        public bool HasCarrier { get; set; }

        public Motorcycle(string brand, int speed, bool hasCarrier) : base(brand, speed)
        {
            HasCarrier = hasCarrier;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Has Carrier: {(HasCarrier ? "Yes" : "No")}");
        }
    }
}
