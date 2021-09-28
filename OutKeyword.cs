using System;

class OutKeyaord{
    public static void Method(int a, int b, out int add, out int sub, out int mul) {
        add = a+b;
        sub = a-b;
        mul = a*b;
    }

    public static void Main(string[] args){
        int num1=40, num2=60, add, sub, mul;
        Method(num1,num2, out add, out sub, out mul);
        Console.WriteLine("Addition: {0}\nSubtraction: {1}\nMultiplication: {2}",add, sub, mul);
    }
}