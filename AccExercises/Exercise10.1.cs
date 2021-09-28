using System;

class Trainer {
    private int EmpId;
    private string EmpName;
    private string Technology;

    public Trainer(){
        EmpId = 0;
        EmpName = "NULL";
        Technology = "NULL";
        Console.WriteLine("\nEmployee Id: {0}\nEmployeeName: {1}\nTechnology: {2}", EmpId, EmpName, Technology);
    }
    public Trainer(int empId, string empName, string tech){
        Console.WriteLine("\nEmployee Id: {0}\nEmployeeName: {1}\nTechnology: {2}", empId, empName, tech);
    }
}

class CunstructorInAction {
    public static void Main(string[] args){
        Trainer t1 = new Trainer();     // Default contructor
        Trainer t2 = new Trainer(10201, "Ishan Jawade", "Java"); // ---_ Parameterized Constructor
        Trainer t3 = new Trainer(10202, "Advait Jawade", "C++"); // ---
    }
}