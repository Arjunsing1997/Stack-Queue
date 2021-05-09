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

            Console.WriteLine("Stack");//Print 
            Stack stack = new Stack(); //create object of Stack class
            stack.Push(56); //call Push method Push element in stack 
            stack.Push(30);
            stack.Push(70);
            stack.Display();//call Display method Display element in stack 
            Console.ReadLine();
        }
    }
}
