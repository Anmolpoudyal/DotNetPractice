using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5
{
    // Abstract class
    public abstract class Vehicle1
    {
        // Abstract methods (no body)
        public abstract void StartEngine();
        public abstract void StopEngine();

        // Concrete method
        public void Display()
        {
            Console.WriteLine("This is a vehicle");
        }
    }

}
