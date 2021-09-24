using System;
using System.Collections.Generic;

class FibonacciSeries{
    static void Main(String[] args){
    
        var fibonacci = new List<int> {1,1};
        
        while(fibonacci.Count < 20){

            var prev = fibonacci[fibonacci.Count - 1];
            var prev2 = fibonacci[fibonacci.Count - 2];        

            fibonacci.Add(prev + prev2);
        }
        foreach(var num in fibonacci)
            Console.Write($"{num} ");
        Console.WriteLine($"");
        Console.WriteLine($"Length of fibonacci series is: {fibonacci.Count}");
    }
}