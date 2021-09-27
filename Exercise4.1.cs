// Print the sum of digits in the number
using System;

class SumOfDigits {
    public static void Main(string[] args){
        Console.WriteLine("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum=0;
        while(num > 0){
            sum += (num%10);
            num/=10;
        }
        Console.WriteLine("Sum of the digits: "+ sum);
    }
}