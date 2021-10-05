using System;
using System.Collections;

class MySortedList {

    public static void Main(string[] args){

        SortedList st = new SortedList();

        st.Add(123, "asdjnkjnc");
        st.Add(121, "asdasdasd");
        st.Add(122, "nciniufn");
        st.Add(124, "iutquyr67");
        
        System.Console.WriteLine("Elements in the hasstable: ");

        foreach (DictionaryEntry de in st){
            System.Console.WriteLine("Key: "+de.Key+" Value: "+de.Value);
        }
    }
}