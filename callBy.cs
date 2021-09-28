using System;

class CallBy{
    public void CallByVal(int a, int b) {
        a += 5;
        b += 5; 
    }

    public void CallByRef(ref int a, ref int b) {
        a += 5;
        b += 5; 
    }

    public static void Main(string[] args){
        CallBy cb = new CallBy();
        int num1=40, num2=60;
        cb.CallByVal(num1, num2);
        Console.WriteLine("Values after calling by value: "+num1+" "+num2);
        cb.CallByRef(ref num1, ref num2);
        Console.WriteLine("Values after calling by reference: "+num1+" "+num2);
    }
}