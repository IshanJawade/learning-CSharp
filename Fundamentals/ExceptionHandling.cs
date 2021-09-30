using System;

class ExceptionHandling {
    public static void Main(string[] args){
        try{
            int num = 100, result;
            result = num/0;
            Console.WriteLine(result);
        }
        catch(DivideByZeroException div){
            Console.WriteLine(div.StackTrace);
        }
        catch(ArrayTypeMismatchException err){
            Console.WriteLine(err);
        }
        catch(NullReferenceException nul){
            Console.WriteLine(nul);
        }
        finally{
        }
    }
}