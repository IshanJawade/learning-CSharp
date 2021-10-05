using System;
using System.Collections;

class MyArrayList {
    public static void Main(string[] args){
        ArrayList arrlist = new ArrayList();
        arrlist.Add(1234);
        arrlist.Add("Ishan");
        arrlist.Add("C052425");
        arrlist.Add(false);
        arrlist.Add("A");
        arrlist.Add(3.1474);

        foreach(object ob in arrlist){      // Object can have any datatype
            Console.WriteLine(ob);
        }
    }
}