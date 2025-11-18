using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    public class debugging
    {

        public void  debug()
        {
            Console.Write("Enter marks: ");
            bool isMarksValid = int.TryParse(Console.ReadLine(), out int marks);

            Console.Write("Enter total: ");
            bool isTotalValid = int.TryParse(Console.ReadLine(), out int total);

            if (!isMarksValid || !isTotalValid)
            {
                Console.WriteLine("Invalid input. Please enter numbers only.");
                return;
            }
            //break point starts here 
            // ❗ BUG: integer division happens here
            //-> before debug   (double percentage = marks / total * 100;)

            //after dbug
            double percentage = (double)marks / total * 100;

            Console.WriteLine($"Percentage: {percentage}");
            // break point ends here 

            //NOTES:
            //observed that the percentage value will be zero 
            /* Why it failed is beacuse marks/ total is integer division, so decimals are removed. */



        }


    }


}
