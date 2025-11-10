using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class NullOperations
{
   
    public void PerformNullChecks()
    {
        // 1. Declare a string variable with null
        string username = null;

        // 2. Ternary Operator
        Console.WriteLine(username == null ? "Username is not available" : username);

        // 3. Null-Coalescing Operator (??)
        Console.WriteLine(username ?? "Username is not available");

        // 4. Null-Coalescing Assignment Operator (??=)
        username ??= "DefaultUser";

        // 5. Print updated username
        Console.WriteLine("Updated username: " + username);

    }



}
