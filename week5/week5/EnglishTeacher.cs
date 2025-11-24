using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5
{
    // Derived class: EnglishTeacher does NOT override Teaching
    public class EnglishTeacher : Teacher
    {
        public EnglishTeacher(string name) : base(name) { }
    }

}
