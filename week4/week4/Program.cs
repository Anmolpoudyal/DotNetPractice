using System.Xml.Serialization;

namespace week4
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // ----------- Task 1: Create Student Objects-------------------------

            // Creating first object
            Student student1 = new Student();
                student1.name = "Anmol";
                student1.Address = "Kathmandu";
                student1.student_id = 101;

            // Creating second object
            Student student2 = new Student();
            student2.name = "Srijana";
            student2.Address = "Lalitpur";
            student2.student_id = 102;

            // Displaying values for student1
            Console.WriteLine("Student 1 Details:");
            Console.WriteLine($"Name: {student1.name}");
            Console.WriteLine($"Address: {student1.Address}");
            Console.WriteLine($"Student ID: {student1.student_id}");
            Console.WriteLine();

            // Displaying values for student2
            Console.WriteLine("Student 2 Details:");
            Console.WriteLine($"Name: {student2.name}");
            Console.WriteLine($"Address: {student2.Address}");
            Console.WriteLine($"Student ID: {student2.student_id}");
            Console.WriteLine();


            // Displaying static field
            Console.WriteLine("Static Field:");
            Console.WriteLine($"Student count: {Student.StudentCount}");


            // ----------- Task 2: Calculator -------------------------
            //---------------------------------------------------------

            // Creating Calculator object and using Add method
            Calculator calculator = new Calculator();
            Console.WriteLine($"The added number is {calculator.Add(5, 10)}");

            //Creating Calculator object and using Multiply method
            Console.WriteLine($"The multiplied number is {calculator.Multiply(5)}");


            // ----------- Task 3: Parameter demo -------------------------
            //---------------------------------------------------------


            ParameterDemo parameterDemo = new ParameterDemo();
            // -------- 1. Calling Increase() with ref --------
            int value = 20;
            parameterDemo.Increase(ref value);
            Console.WriteLine($"Value after Increase(): {value}");

            // -------- 2. Calling GetFullName() with out --------
            string fullName;
            parameterDemo.GetFullName(out fullName);
            Console.WriteLine($"Full Name from out parameter: {fullName}");

            // -------- 3. Calling SumAll() with params --------
            int total = parameterDemo.SumAll(5, 10, 15, 20);
            Console.WriteLine($"Sum of all numbers: {total}");

            Console.WriteLine();

            // ----------- Task 4: Players  -------------------------
            //---------------------------------------------------------


            // Creating object using default constructor
            Player p1 = new Player();
            Console.WriteLine("\nPlayer 1 Details:");
            Console.WriteLine($"Name: {p1.playerName}");
            Console.WriteLine($"Level: {p1.level}");
            Console.WriteLine($"Health: {p1.health}");

            // Creating object using parameterized constructor
            Player p2 = new Player("Anmol", 5, 100);
            Console.WriteLine("\nPlayer 2 Details:");
            Console.WriteLine($"Name: {p2.playerName}");
            Console.WriteLine($"Level: {p2.level}");
            Console.WriteLine($"Health: {p2.health}");
            Console.WriteLine();

            // ----------- Task 5: Daytypes   -------------------------
            //---------------------------------------------------------
            // ---------------- ENUM PART ----------------

            Console.Write("Enter a day (Example: Sunday): ");
            string inputDay = Console.ReadLine().Trim().ToLower();

            DayType dayType;

            // Check for Weekend
            if (inputDay == "friday" || inputDay == "saturday")
            {
                dayType = DayType.Weekend;
            }
            else
            {
                dayType = DayType.Weekday;
            }

            Console.WriteLine($"It is: {dayType}");
            Console.WriteLine();


            // ---------------- RECORD PART ----------------

            // Creating first Book object
            Book book1 = new Book("C# Fundamentals", "John Doe", 29.99);

            // Creating second object using with-expression (copy with changes)
            Book book2 = book1 with
            {
                title = "Advanced C#",
                price = 39.99
            };

            // Printing book1 values
            Console.WriteLine("Book 1 Details:");
            Console.WriteLine($"Title: {book1.title}");
            Console.WriteLine($"Author: {book1.author}");
            Console.WriteLine($"Price: {book1.price}");

            Console.WriteLine();

            // Deconstructing book2
            var (title, author, price) = book2;

            Console.WriteLine("Book 2 Details (After Deconstruction):");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: {price}");


            // ----------- Task 6: debugging    -------------------------
            //---------------------------------------------------------
            debugging debug1 = new debugging();
            debug1.debug();


        }

        public enum DayType
        {
            Weekday,
            Weekend
        }

        public record Book(string title, string author, double price);
    }





}
