using System;

public interface IMyInterface {
    int add(int a, int b);      // no access modifire is required in interfaces
    int sub(int a, int b);
}

class Calculations : IMyInterface {
    public int add(int num1, int num2){
        int ans = num1 + num2;
        return ans;
    }

    public int sub(int num1, int num2){
        int ans = num1 - num2;
        return ans;
    }
}
class TestingInterface {
    public static void Main(string[] args){
        IMyInterface cal = new Calculations();
        Console.WriteLine(cal.add(23, 45));
        Console.WriteLine(cal.sub(67, 34));
    }
}