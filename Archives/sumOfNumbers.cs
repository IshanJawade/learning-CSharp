// some of numbers which is divisible by 3 between 1-20
 using System;

 class SumOfNumbers{
     static void Main(String[] args){
         int sum = 0;
         for (int i = 1; i <= 20; i++)
         {
            if (i%3 == 0)
            {
                sum = sum + i;
            }
         }
         Console.WriteLine($"The Sum is {sum}");
    }
 }