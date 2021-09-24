using System;
    public class AdditionByUserInput {
        
        static int addition(int num1, int num2){
            int ans = num1 + num2;
            return ans;
        }
        
        public static void Main(String[] args){
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(addition(a,b));
        }
    } 