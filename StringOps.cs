using System;

class StringOps {
    public static void Main(String[] args) {
        string firstName = "Ishan";
        string lastName = "Jawade";
        
        // concatination syntax
        string fullName = $"{firstName} {lastName}"; 
        
        //Method 1 to insert veriable into output string
        Console.WriteLine("First Name: {0}\nLast Name: {1}\nFull Name: {2}",firstName, lastName, fullName);
        //Method 2 to insert veriable into output string
        Console.WriteLine($"\nFirst Name: {firstName}\nLast Name: {lastName}\nFull Name: {fullName}");
        
        // perticular char in string
        Console.WriteLine(firstName[3]);
        // Length of string
        Console.WriteLine(fullName.Length);
        // UpperCase
        Console.WriteLine(fullName.ToUpper());
    }
        
}  