using System;
public delegate int DelMethod(int a, int b);    // Declaration of  Delegate
class TestDelegate {
    public int Add(int a, int b){
    return a+b;
    }
    public int Subtract(int a, int b){
        return a+b;
    }
    public int Multiply(int a, int b){
        return a+b;
    }
    public static void Main(){
        TestDelegate td = new TestDelegate();

        DelMethod AddDelegate = new DelMethod(td.Add);    
        DelMethod SubDelegate = new DelMethod(td.Subtract);    
        DelMethod MulDelegate = new DelMethod(td.Multiply);    

        int addAns = AddDelegate(10, 15);
        int subAns = SubDelegate(40, 20);
        int mulAns = MulDelegate(2, 5);
        
        Console.WriteLine("Addition: {0}\nSubtration: {1}\nMultiplication: {}", addAns, subAns, mulAns);
    }
    
}