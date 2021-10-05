using System;
using System.Collections;

class MyHashTables {
    public static void Main(string[] args) {
        Hashtable ht = new Hashtable();

        ht.Add(123, "asdjnkjnc");
        ht.Add(121, "asdasdasd");
        ht.Add(122, "nciniufn");
        ht.Add(124, "iutquyr67");
        
        System.Console.WriteLine("Elements in the hashtable: ");
        foreach (DictionaryEntry de in ht){
            System.Console.WriteLine("Key: "+de.Key+" Value:"+de.Value);
        }

        try
        {
             ht.Add(123, "Something!!");        // keys should be unique!!!
        }
        catch 
        {
            Console.WriteLine("An element with this key is already exists.");
        }

    }
}