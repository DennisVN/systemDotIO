using System;
using System.Collections;

namespace systemDotIO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Queue (First in First out !)

            /* Use Queue if you need to access the information in the same order that it is stored in the collection. 
            Use Stack if you need to access the information in reverse order. */

            // Three main operations can be performed on a Queue and its elements: Enqueue , Dequeue & Peek
            // Enqueue: Adds element to the END, Dequeue removes oldest element from the Start, Peek returns oldest element at the start, but does not remove it. 

            System.Collections.Queue l = new Queue();
            l.Enqueue("abc");
            l.Enqueue(123);
            l.Enqueue(true);
            object o = l.Peek();


            Console.WriteLine(l.Count);
            Console.WriteLine((string) o);
            Console.WriteLine(l.Count);
            o = l.Dequeue();
            Console.WriteLine(l.Count);
            Console.WriteLine((string)o);
            Console.WriteLine(l.Count);
        }
    }
}
