using System;

class EnumSample {
    public enum months{
        january = 1, 
        february = 2,
        march = 3, 
        april = 4, 
        may = 5, 
        june= 6,
        july = 7,
        august = 8,
        septeber = 9,
        october = 10,
        november = 11,
        december = 12
    }
    public static void Main(String[] args){
        Console.WriteLine(months.january);
        Console.WriteLine((int)months.january);
        
    }
}