using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack Program....");

            //Console.WriteLine("Stack");//Print 
            //Stack stack = new Stack(); //create object of Stack class
            //stack.Push(56); //call Push method Push element in stack 
            //stack.Push(30);
            //stack.Push(70);

            //stack.Peek(); //call Peek method print top of stack //UC2
            //stack.Pop(); //call Pop method and remove top of the stack //UC2
            //stack.isEmpty(); //call isEmpty method remove all elements in stack//UC2
            //stack.Display();//call Display method Display element in stack 

            Console.WriteLine("Queue"); //Print 
            Queue queue = new Queue();  //create object of Queue class
            queue.Enqueue(56); //call method add Element in queue //UC1
            queue.Enqueue(30); //call method add Element in queue //UC1
            queue.Enqueue(70); //call method add Element in queue //UC1
            queue.Display(); //call Display method Display element in Queue  //UC1
            queue.Peek(); //call Display method Display Top of the element in Queue  //UC1

            queue.Dequeue(); //call Dequeue method //UC2
            queue.IsEmpty(); //call IsEmpty method //UC2
            Console.ReadLine();
        }
    }
}
