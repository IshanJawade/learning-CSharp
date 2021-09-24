using System;
using System.Collections.Generic;

class listsInCSharp{
    static void Main(String[] args){
        var names = new List<string>  {"Ishan", "Pratik", "Advait", "Puppy"}; //Array

        //Iterating List by "foreach" Method
        foreach (var name in names){
            Console.WriteLine($"Hello {name}. Whats up !");   
        }

        //Iterating List by traditional "for loop" Method
        for (int i=0; i < names.Count; i++){
            Console.WriteLine($"Hello {names[i]}. Whats up !");
        }

        //Adding and revoming items in the list
        names.Add("Ayushi");
        names.Add("Rushikesh");
        names.Remove("Ishan");

        foreach (var name in names){
            Console.WriteLine(name);   
        }

        //Accessing Array directly by its Index
        Console.WriteLine(names[0]);
        Console.WriteLine(names[1]);
        Console.WriteLine(names[2]);
        Console.WriteLine(names[3]);
        
    }
}