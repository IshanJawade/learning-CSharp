using System;
using System.Text; // for string builder

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
        
        // print perticular char at index in string
        Console.WriteLine(firstName[3]);

        // Length of string
        Console.WriteLine(fullName.Length);

        // UpperCase and LowerCase
        Console.WriteLine(fullName.ToUpper());
        Console.WriteLine(fullName.ToLower());

        // Make a clone
        string firstNameClone = Convert.ToString(firstName.Clone());
        Console.WriteLine(firstNameClone);

        // Compare two string (returns '0 for true' or '1 for false')
        System.Console.WriteLine(firstName.CompareTo(firstName));

        // Check the string is present on the string or not (returns true or false)
        System.Console.WriteLine(firstName.Contains("sha"));
        System.Console.WriteLine(firstName.EndsWith("n"));
        System.Console.WriteLine(firstName.StartsWith("I"));

        // Compare two string (return true or false)
        System.Console.WriteLine(firstName.Equals(lastName));

        // Insert substring in a string
        System.Console.WriteLine(firstName.Insert(0, "Hello "));

        // Remove and Replace
        System.Console.WriteLine(firstName.Remove(3));
        System.Console.WriteLine(fullName.Replace("a", "z"));

        // Crop a string 
        System.Console.WriteLine(fullName.Substring(2,5));

        //Convert string into char array
        System.Console.WriteLine(fullName.ToCharArray());

        //Removes only starting and Ending blank spaces from the string
        System.Console.WriteLine(fullName.Trim());


        //++++++++++++++++++ String Builder Ops ++++++++++++++++++++++
        StringBuilder strBuild = new StringBuilder("Hi!!");
        System.Console.WriteLine(strBuild);
        
        strBuild.Append("kichiki");
        strBuild.AppendLine("kdk suit and all are there!");
        System.Console.WriteLine(strBuild);

    }
        
}  