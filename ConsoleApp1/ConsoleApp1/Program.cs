using System;
using System.Collections.Generic;
using System.Text;
using Collections;
using Rectangle;

namespace ConsoleApp1
{
    class Test
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Rectangle1 r = new Rectangle1();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }
}
