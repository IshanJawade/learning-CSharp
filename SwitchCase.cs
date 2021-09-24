using System;

class SwitchCase{
    public static void Main(String[] args){
        char grade = 'A';
        switch (grade)
        {
            case 'A': Console.WriteLine("Excellent");
                break;
            case 'B': Console.WriteLine("Great");
                break;
            case 'C': Console.WriteLine("Good");
                break;
            case 'D': Console.WriteLine("Needs Improvement");
                break;
        }

    }
}