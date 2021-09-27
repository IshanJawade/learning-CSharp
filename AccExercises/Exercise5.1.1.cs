// Input 8 integers and display sum of all Even and Odd numbers 
using System;

class Program{
    public static void Main(string[] args){
        int[] arr = new int[7];
        int sumEven=0, sumOdd=0;
        Console.WriteLine("Enter 8 integers: ");
        for (int i=0; i < arr.Length; i++){
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        foreach (int num in arr){
            if (num%2 == 0){
                sumEven += num;
            }
            else{
                sumOdd += num;
            }
        }
        Console.WriteLine("Sum of Even numbers: "+sumEven);
        Console.WriteLine("Sum of Odd numbers: "+sumOdd);
    }
}