using static System.Runtime.InteropServices.JavaScript.JSType;

namespace week5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1:--------------------------------
            //------------------------------------------------

            //create an object of bank Account, display the account number, deposit and then withdraw the money. Then print the remaining balance.

            BankAccount myAccount = new BankAccount();
            Console.WriteLine($"Account Number: {myAccount.AccountNumber}");
            myAccount.Deposit(500);
            myAccount.Withdraw(200);
            Console.WriteLine($"Remaining Balance: {myAccount.Balance}");
            //------------------------------------------------

            //Task 2:--------------------------------
            // Creating objects of derived classes
            Car myCar = new Car("Toyota", 120, 5);
            Motorcycle myMotorcycle = new Motorcycle("Yamaha", 90, true);

            // Using base class methods (code reusability)
            Console.WriteLine("=== Car ===");
            myCar.Start();         // Base class method
            myCar.DisplayInfo();   // Overridden method
            myCar.Stop();          // Base class method

            Console.WriteLine();

            Console.WriteLine("=== Motorcycle ===");
            myMotorcycle.Start();       // Base class method
            myMotorcycle.DisplayInfo(); // Overridden method
            myMotorcycle.Stop();        // Base class method

            //------------------------------------------------
            Console.WriteLine();

            //Task 3:--------------------------------
            //---------polymorphism with method overloading---------
            // Create Printer object
            Printer myPrinter = new Printer();

            // Call Print(string)
            Console.WriteLine("=== Print(string) ===");
            myPrinter.Print("Hello, World!");

            // Call Print(int)
            Console.WriteLine("\n=== Print(int) ===");
            myPrinter.Print(42);

            // Call Print(string, int)
            Console.WriteLine("\n=== Print(string, int) ===");
            myPrinter.Print("Repeat this message", 3);

            //task3 second task
            //---------------------
            Teacher englishTeacher = new Teacher("Mr. Sharma");
            englishTeacher.Teaching();    // Output: Teacher teaches in English
            Teacher.SalaryInfo();    // Output: Teacher's salary information is confidential

            Console.WriteLine();

            NepaliTeacher nepaliTeacher = new NepaliTeacher("Ms. Karki");
            nepaliTeacher.Teaching();     // Output: Teacher teaches in Nepali
            Teacher.SalaryInfo();    // Output: Teacher's salary information is confidential

            Console.WriteLine();

            EnglishTeacher englishTeacher2 = new EnglishTeacher("Mr. Joshi");
            englishTeacher2.Teaching();   // Output: Teacher teaches in English (base class method)
            Teacher.SalaryInfo(); // Output: Teacher's salary information is confidential

            //---------------------
            Console.WriteLine();



            //Task 4:--------------------------------
            // Abstraction--------------------------------
            // Create objects of Car and Motorcycle
            Vehicle1 myCar1 = new Car1();
            Vehicle1 myBike = new Motorcycle1();

            // Using Car object
            Console.WriteLine("=== Car ===");
            myCar1.Display();       // Concrete method from Vehicle
            myCar1.StartEngine();   // Abstract method implemented in Car
            myCar1.StopEngine();

            Console.WriteLine();

            // Using Motorcycle object
            Console.WriteLine("=== Motorcycle ===");
            myBike.Display();      // Concrete method from Vehicle
            myBike.StartEngine();  // Abstract method implemented in Motorcycle
            myBike.StopEngine();

            //Task 5 :--------------------------------\
            // OOP
            // Create ElectronicsStore
            ElectronicsStore store = new ElectronicsStore();

            // Create Laptop and Smartphone objects
            Laptop myLaptop = new Laptop("Dell", 1499.50);
            Smartphone myPhone = new Smartphone("Apple", 999.99);

            // Add devices to the store
            store.AddDevice(myLaptop);
            store.AddDevice(myPhone);

            // Display all device info including child-specific behavior
            store.ShowAllDeviceDetails();

        }
    }
}
