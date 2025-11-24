using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5
{
    /*Create a class named Teacher with the following specifications:
  A property called Name.
  A method Teaching() that prints "Teacher teaches in English".
  Another method SalaryInfo() that cannot be overridden by any child classes.
  */
    public class Teacher
    {
        // Property
        public string Name { get; set; }

        // Constructor
        public Teacher(string name)
        {
            Name = name;
        }

        // Method: Teaching
        public virtual void Teaching() // Marked as virtual to allow override
        {
            Console.WriteLine("Teacher teaches in English");
        }

        // Method: SalaryInfo (cannot be overridden)
        public static void SalaryInfo()
        {
            Console.WriteLine("Teacher's salary information is confidential");
        }
    }



}
