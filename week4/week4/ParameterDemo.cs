using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    public class ParameterDemo
    {
        // Method demonstrating 'ref' parameter
        public void  Increase(ref int number)
        {
           number = number + 10;
        }

        // Method demonstrating 'out' parameter
        public void  GetFullName (out string fullname)
        {
            fullname = "Anmol Poudyal";
        }

        // Method demonstrating 'params' parameter
        public int SumAll(params int[] numbers)
        {
            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }

            return sum;
        }

    }
}
