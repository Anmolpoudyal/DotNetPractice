using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5
{
    public class Motorcycle1 : Vehicle1
    {
        public override void StartEngine()
        {
            Console.WriteLine("Motorcycle engine started");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Motorcycle engine stopped");
        }
    }
}
