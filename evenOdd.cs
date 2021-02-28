using System;
class EevenOdd{
        static void Main(String[] args){
            Console.WriteLine("Even Numbers: ");
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {  
                    
                    Console.WriteLine(i);
                } 
            }
            Console.WriteLine("Odd Numbers: ");
            for (int i = 0; i <= 10; i++)
            {
                if(i % 2 != 0){
                    Console.WriteLine(i);
                }
            }  
        }
}
