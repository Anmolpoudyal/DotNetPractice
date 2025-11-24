using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5
{
    public class NepaliTeacher : Teacher
    {
        public NepaliTeacher(string name) : base(name)
        {
        }

        // Override the Teaching method
        public override void Teaching()
        {
            Console.WriteLine("Teacher teaches in Nepali");
        }


    }
}
