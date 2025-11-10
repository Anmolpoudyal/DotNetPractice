namespace week2Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For task 1

            Calculator operators = new Calculator();
            Console.WriteLine("Addition: " + operators.Add(5, 3));
            Console.WriteLine("Subtraction: " + operators.Subtract(5, 3));
            Console.WriteLine("Multiplication: " + operators.Multiply(5, 3));
            Console.WriteLine("Division: " + operators.Divide(5, 3));

            //task 2 
            NullOperations nulloperator = new NullOperations();
            nulloperator.PerformNullChecks("Anmol");
            //task 2 
            nulloperator.PerformNullChecks(null);

            // task 3 if else  cases
            // Ask user to input age
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            // Check age category
            if (age < 13)
            {
                Console.WriteLine("You are a Child.");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("You are a Teenager.");
            }
            else if (age >= 20)
            {
                Console.WriteLine("You are an Adult.");
            }
            else
            {
                Console.WriteLine("Invalid age!");
            }

            // for the task 3 switch statment

            Console.Write("Enter a number (1–7) to display the day of the week: ");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;

                default:
                    Console.WriteLine("Invalid day number!");
                    break;
            }
            //task 5 loops
            // -------------------------------
            // 1. Sum from 1 to N using for loop
            // -------------------------------
            Console.Write("Enter a number N: ");
            int N = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum += i;
            }

            Console.WriteLine("Sum from 1 to " + N + " = " + sum);

            // task 5 loops
            // -------------------------------
            // 2. Print numbers 1–20 using while loop
            //    Skip multiples of 4 (continue)
            //    Stop when number is 15 (break)
            // -------------------------------
            Console.WriteLine("\nNumbers from 1 to 20 (skipping multiples of 4, stopping at 15):");

            int num = 1;

            while (num <= 20)
            {
                if (num == 15)
                    break;

                if (num % 4 == 0)
                {
                    num++;
                    continue;
                }

                Console.WriteLine(num);
                num++;
            }


             //task 5 loops
            // 3. Sum of array elements using foreach loop
            
            int[] numbers = { 5, 10, 3, 7, 2 };

            int arraySum = 0;

            foreach (int x in numbers)
            {
                arraySum += x;
            }

            Console.WriteLine("\nSum of array elements = " + arraySum);

            //task 6 exception handling
            // -------------------------------
            // 1. Convert input to integer with exception handling
            // -------------------------------
            try
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                int number = int.Parse(input);   // may cause exception
                Console.WriteLine("Converted number: " + number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format");
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }

            // task 6 exception handling
            // -------------------------------
            // 2. Password validation with throw
            // -------------------------------
            try
            {
                Console.Write("\nEnter your password: ");
                string password = Console.ReadLine();

                if (password.Length < 6)
                {
                    throw new Exception("Password must be at least 6 characters.");
                }

                Console.WriteLine("Password satisfied the requirement");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        // for task 1
        //odd even finder 
        public void OddEvenFinder(int number)
        {
            //using TERNARY OPERATOR 
            string result = (number % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine($"{number} is {result}");
        }






    }




}



