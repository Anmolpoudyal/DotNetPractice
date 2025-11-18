using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    public class Calculator
    {
        // Method 1: Prints welcome message
        void PrintWelcome()
        {
           Console.WriteLine("Welcome to the Calculator!");
        }

        // Method 2: Adds two integers and returns the result
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Method 3: Multiplies two numbers (num2 optional with default value 1)
        public int Multiply(int num1, int num2 = 1)
        {
            return num1 * num2;
        }

    }
}
