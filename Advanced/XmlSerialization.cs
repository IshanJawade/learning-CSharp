using System;
using System.Collections;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.IO;

public class Employee {
    public int employeeId {get; set;}
    public string employeeName {get; set;}
    public string[] skills {get; set;}
}

class TestXMLSerialization {
    public static void Main(string[] args) {
        Employee employee  = new Employee{
            employeeId = 1,
            employeeName = "Ishan",
            skills = new string[] {"C#", "Java", "Python", "C++"}
        };

        System.Console.WriteLine("Employee ID: "+employee.employeeId);
        System.Console.WriteLine("Employee Name: "+employee.employeeName);
        System.Console.WriteLine("Employee Skills: "+employee.skills[0]);

        XmlSerializer serializer = new XmlSerializer(typeof(Employee));     //Error
        using(
            FileStream file = new FileStream(
                "result.txt", FileMode.OpenOrCreate, FileAccess.Write
            )
        ){
            serializer.serializer(file, Employee);                          //Error
        }
    }
}