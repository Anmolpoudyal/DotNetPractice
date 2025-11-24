using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5
{
    /*
     Create a class Printer with the following overloaded methods:
    Print(string message), Print(int number) and Print(string message, int count)

     */
    public class Printer
    {
        // Method 1: Print a string message
        public void Print(string message)
        {
            Console.WriteLine("Message: " + message);
        }

        // Method 2: Print an integer number
        public void Print(int number)
        {
            Console.WriteLine("Number: " + number);
        }

        // Method 3: Print a string message multiple times
        public void Print(string message, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}: {message}");
            }
        }
    }
    




}
