using System;
using System.Collections;

class StackImplementation {
    public static void Main(string[] args) {

        // ************** Stack *****************
        System.Console.WriteLine("************** Stack *****************");
        Stack st = new Stack();
        st.Push("ishan");
        st.Push(1212);
        st.Push("A");
        st.Push(false);
        st.Push("This is a String");

        System.Console.WriteLine("Elements of Stack: ");
        foreach(object ob in st){      // Object can have any datatype
            Console.WriteLine(ob);
        }

        st.Pop();
        st.Pop();

        System.Console.WriteLine("\nElements of Stack after Pop: ");
        foreach(object ob in st){      // Object can have any datatype
            Console.WriteLine(ob);
        }

        System.Console.WriteLine("\nPeek operation returns TOP of stack: "+st.Peek());

        //************ Queue ***************
        System.Console.WriteLine("\n************ Queue ****************");

        Queue q = new Queue();

        q.Enqueue("Ishan");
        q.Enqueue(12121);
        q.Enqueue("A");
        q.Enqueue(true);
        q.Enqueue("String is best");

        System.Console.WriteLine("Elements in queue after Enqueue: ");
        foreach(object ob in q){      // Object can have any datatype
            Console.WriteLine(ob);
        }

        q.Dequeue();
        q.Dequeue();
        q.Dequeue();

        System.Console.WriteLine("\nElements in queue after Dequeue: ");
        foreach(object ob in q){      // Object can have any datatype
            Console.WriteLine(ob);
        }

        

    }
}