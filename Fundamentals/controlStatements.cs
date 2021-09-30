using System;
 
 class ControlStatements{
     public static void Main(String[] args){
        int a = 120, b = 45;

        // Traditional Method {if else}
        if (a>b)
            Console.WriteLine("a is big");
        else
            Console.WriteLine("b is big");

        // New Method {? :}
        string result = a > b ? "a is big" : "b is big";
        Console.WriteLine(result); 
     }
 }