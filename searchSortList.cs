using System;
using System.Collections.Generic;

class listsInCSharp{
    static void Main(String[] args){
    
        var heros = new List<string> 
        {"Ironman", "Spiderman", "Captain America", "Antman", "Thor", "Hulk"};

        foreach(var hero in heros){
            Console.Write($"{hero} ");
        }
        Console.WriteLine("");

        //Finding index
        var index = heros.IndexOf("Ironman");
        if (index == -1){
            Console.WriteLine("Item not found");
        }
        else{
            Console.WriteLine($"Index is {index}");
        }

        //sort the array 
        heros.Sort();
        Console.WriteLine($"Sorted Array: ");
        foreach(var hero in heros){
            Console.Write($"{hero} ");
        }
        Console.WriteLine($"");
    }
}    