using System;
using System.Collections;
using System.Runtime.Serialization.json;
using System.IO;
using System.Text.Json;

namespace JSON {
    public class Employee {
        public int employeeId {get; set;}
        public string employeeName {get; set;}
        public string[] skills {get; set;}
    }

    class TestJSONSerialization {
        public static void Main(string[] args) {
            Employee employee  = new Employee{
                employeeId = 1,
                employeeName = "Ishan",
                skills = new string[] {"C#", "Java", "Python", "C++"}
            };

            Seria
        }
    }
}