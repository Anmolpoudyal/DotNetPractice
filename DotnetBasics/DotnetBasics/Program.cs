namespace DotnetBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------
            // Task 1: String Interpolation
            // ----------------------------------------------------
            /*
            Write a C# program that performs the following:
            - Declare a variable named userName to store your name and initialize it.
            - Declare a variable named luckyNumber to store an integer and initialize it to your favorite single-digit number.
            - Use string interpolation to print:
              "Hello, [userName]! Your lucky number is [luckyNumber]."
            */
            string userName = "Anmol";
            int luckyNumber = 7;
            Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");
            Console.WriteLine();

            // ----------------------------------------------------
            // Task 2: Constants (Class Circle)
            // ----------------------------------------------------
            /*
            Create a class named Circle.
            Inside the class, declare a constant variable named PI = 3.14.
            In Main(), try to modify PI (will cause an error if uncommented).
            Also create methods to calculate area and perimeter.
            */
            Circle myCircle = new Circle(5); // radius = 5
            Console.WriteLine($"Area of circle: {myCircle.CalculateArea()}");
            Console.WriteLine($"Perimeter of circle: {myCircle.CalculatePerimeter()}");

            // Uncommenting the below line will cause a compilation error because PI is constant
            // Circle.PI = 3.14159;
           
            Console.WriteLine();

            // ----------------------------------------------------
            // Task 3: Data Types and Type Conversion
            // ----------------------------------------------------
            /*
            - Declare and initialize variables of byte, short, int, long, float, double, decimal, char, bool.
            - Convert integer 42 to string.
            - Convert string "3.14" to double.
            - Print all variables.
            */
            byte myByte = 25;
            short myShort = 32000;
            int myInt = 100000;
            long myLong = 123456789L;
            float myFloat = 3.14f;
            double myDouble = 3.141592;
            decimal myDecimal = 3.14159265358979m;
            char myChar = 'A';
            bool myBool = true;

            string intToString = 42.ToString();
            double stringToDouble = Convert.ToDouble("3.14");

            Console.WriteLine($"byte: {myByte}");
            Console.WriteLine($"short: {myShort}");
            Console.WriteLine($"int: {myInt}");
            Console.WriteLine($"long: {myLong}");
            Console.WriteLine($"float: {myFloat}");
            Console.WriteLine($"double: {myDouble}");
            Console.WriteLine($"decimal: {myDecimal}");
            Console.WriteLine($"char: {myChar}");
            Console.WriteLine($"bool: {myBool}");
            Console.WriteLine($"Converted int to string: {intToString}");
            Console.WriteLine($"Converted string to double: {stringToDouble}");
            Console.WriteLine();

            // ----------------------------------------------------
            // Task 4: Array and Array Methods
            // ----------------------------------------------------
            /*
            - Create an int array with 5 favorite numbers.
            - Sort ascending, then reverse.
            - Print using for loop.
            - Use Array.IndexOf() to find the position of a specific number.
            */
            int[] favNumbers = { 9, 3, 7, 1, 5 };
            Array.Sort(favNumbers); // ascending
            Array.Reverse(favNumbers); // descending

            Console.WriteLine("Favorite numbers in descending order:");
            for (int i = 0; i < favNumbers.Length; i++)
            {
                Console.WriteLine(favNumbers[i]);
            }

            int searchNumber = 7;
            int position = Array.IndexOf(favNumbers, searchNumber);
            Console.WriteLine($"The number {searchNumber} is at index: {position}");
            Console.WriteLine();

            // ----------------------------------------------------
            // Task 5: DateTime and TimeSpan
            // ----------------------------------------------------
            /*
            - Create DateTime variable for birthdate.
            - Create DateTime for current date.
            - Calculate age using TimeSpan.
            - Print birthdate, current date, and age in years.
            - Add 10 days to birthdate and print new date.
            */
            DateTime birthDate = new DateTime(2002, 8, 15);
            DateTime currentDate = DateTime.Now;
            TimeSpan ageSpan = currentDate - birthDate;
            double ageInYears = ageSpan.TotalDays / 365.25;

            Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
            Console.WriteLine($"Current Date: {currentDate}");
            Console.WriteLine($"Age: {Math.Floor(ageInYears)} years");

            DateTime plusTenDays = birthDate.AddDays(10);
            Console.WriteLine($"Birthdate + 10 days: {plusTenDays.ToShortDateString()}");
        }
    }

    // Circle class for Task 2
    class Circle
    {
        public const double PI = 3.14;
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public double CalculateArea()
        {
            return PI * radius * radius;
        }

        public double CalculatePerimeter()
        {
            return 2 * PI * radius;
        }
    }
}
