using System;

class TestingMath {
    public static void Main(string[] args) {
        double num1 = 175.4367;
        double ceilingNum = Math.Ceiling(num1);
        double floorNum = Math.Floor(num1);
        System.Console.WriteLine(ceilingNum);
        System.Console.WriteLine(floorNum);

        int num = 9;
        System.Console.WriteLine(Math.Sqrt(num));

        int left = -3455, right = -9875;
        System.Console.WriteLine(Math.Abs(left)+" "+Math.Abs(right));

        System.Console.WriteLine(Math.Pow(5, 2));

    }
}