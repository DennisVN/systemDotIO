using System;
using System.Collections;
using System.Collections.Generic; // Array

namespace systemDotIO
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Queue FIFO
            // Queue (First in First out !)

            /* Use Queue if you need to access the information in the same order that it is stored in the collection. 
            Use Stack if you need to access the information in reverse order. */

            // Three main operations can be performed on a Queue and its elements: Enqueue , Dequeue & Peek
            // Enqueue: Adds element to the END, Dequeue removes oldest element from the Start, Peek returns oldest element at the start, but does not remove it. 

            //System.Collections.Queue l = new Queue();
            //l.Enqueue("abc");
            //l.Enqueue(123);
            //l.Enqueue(true);
            //object o = l.Peek();
            //Console.WriteLine("List of Queue Values : ");
            //PrintValues(l);

            //Console.WriteLine(l.Count);
            //Console.WriteLine((string)o);

            //o = l.Dequeue();
            //Console.WriteLine(l.Count);
            //Console.WriteLine((string)o);
            //Console.WriteLine("List of Queue Values : ");
            //PrintValues(l);
            #endregion

            #region Stack LIFO
            // Stack ( Last in First Out ) 
            // Peek() Return the object at the top of the stack without removing it 
            // Pop() Removes and returns the object at the Top of the Stack
            // Push(object) Insert an object at the top of the Stack
            //System.Collections.Stack myStack = new Stack();
            //myStack.Push("def");
            //myStack.Push(456);
            //myStack.Push(true);

            //Console.WriteLine(myStack.Count);   // 3
            //Console.WriteLine(myStack.Peek()); // True
            //Console.WriteLine("List of Stack values : ");
            //PrintValues(myStack);
            #endregion

            #region Array
            // ArrayList Unsorted (Must call Sort() method before operating)

            //System.Collections.Generic.List<object> myList = new List<object>();
            //myList.Add("123456");
            //myList.Add(123465);
            //myList.Add(true);

            //Console.WriteLine("Count : {0}", myList.Count);
            //Console.WriteLine("Capactity : {0}", myList.Capacity);
            //PrintValues(myList);
            #endregion

            Console.ReadLine();
        }
        public static void PrintValues (IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
            {
                Console.Write(" {0}", obj);
                Console.WriteLine();
            }
        }
    }
}
