// Check the number is a pallindrome or not
using System;

class CheckNumPallindrome {
    public static void Main(string[] args){
        int num = Convert.ToInt32(Console.ReadLine());
        string numStr = num.ToString();
        string revSrt = "";
        for (int i=numStr.Length-1; i >= 0; i--){
            revSrt += numStr[i];
        }
        Console.WriteLine("This number is Pallindrome => "+(numStr==revSrt));
    }
}