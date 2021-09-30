using System;

class car {
    public string PrintStuff(){
        string str = "Its PrintStuff fucntion from car class";
        return str;
    }
}

class ClassObject {
    public static void Main(string[] args){
        car obj = new car();
        Console.WriteLine(obj.PrintStuff());
    }
}

