// Print the given pattern in the output screen
using System;

class Pattern {
    public static void Main(String[] args){
        int count = 1;
        for (int i=1; i <= 5; i++){
            for (int j=1; j<=i; j++){
                Console.Write(count);
                Console.Write(" ");
            }
            Console.WriteLine();   // this line just place the curssor on the next line
            count++;
        }
    }
}