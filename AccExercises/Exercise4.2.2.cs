// Check the number is a pallindrome or not
using System;

class CheckNumPallindrome {
    public static void Main(string[] args){
        Console.WriteLine("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        string numStr = num.ToString();
        string revSrt = "";
        for (int i=numStr.Length-1; i >= 0; i--){
            revSrt += numStr[i];
        }
        if (numStr==revSrt)
            Console.WriteLine("The number is a pallindrome.");
        else
            Console.WriteLine("The number is not a pallindrome.");
    }
}