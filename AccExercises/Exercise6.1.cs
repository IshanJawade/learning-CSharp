using System;

class MainClass {
    public static int AddTwoNumbers(int a, int b){
        return a+b;
    }
    public static int SubTwoNumbers(int a, int b){
        return a-b;
    }
    public static int MulTwoNumbers(int a, int b){
        return a*b;
    }
    public static int DivTwoNumbers(int a, int b){
        return a/b;
    }
    public static void CalculateTotalSalary(int a, out double totalSalary){
        double incomeTax = a*0.1;
        totalSalary = (double)a - incomeTax;
    }
    public static void Main(string[] args){
        //Calculator cl = new Calculator();
        int ch = 10;
        while(ch != 0){
            Console.Write("\nMenu:\n1. Add\n2. Sub\n3. Mul\n4. Div\n5. Payroll\n0. Exit\n==> ");
            ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 0){
                Console.WriteLine("Have A Nice Day!");
                break;
            }
            else if (ch == 5){
                Console.WriteLine("\nEnter base salary: ");
                int baseSalary = Convert.ToInt32(Console.ReadLine());
                double totalSalary;
                CalculateTotalSalary(baseSalary, out totalSalary);
                Console.WriteLine("Total salary is (Base Salary - 10% income tax): "+totalSalary);
            }
            else{
                Console.Write("\nEnter first numbers: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second numbers: ");
                int num2 = Convert.ToInt32(Console.ReadLine()); 
                switch (ch)
                {
                    case 1:{
                        Console.WriteLine("Addition: "+AddTwoNumbers(num1, num2));
                        break;
                    }   
                    case 2:{
                        Console.WriteLine("Subration: "+SubTwoNumbers(num1, num2));
                        break;
                    }    
                    case 3:{
                        Console.WriteLine("Multiplication: "+MulTwoNumbers(num1, num2));
                        break;
                    }    
                    case 4:{
                        Console.WriteLine("Division: "+DivTwoNumbers(num1, num2));
                        break;
                    }    
                    default:{
                        Console.WriteLine("Invalid input");
                        break;
                    }   
                }
            }
        }

    }
}