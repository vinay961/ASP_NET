using System;

namespace EventsDelegate
{
    public delegate void Operation(int x, int y);
    class Delegates
    {
        public static void Add(int x, int y) 
        {
            Console.WriteLine($"After adding {x} and {y}, we get " + (x+y));
        }
        public static void Sub(int x, int y)
        {
            Console.WriteLine($"After subtracting {x} and {y}, we get " + (x - y));
        }

        public static void Execute(Operation op,  int x, int y)
        {
            op(x,y);
        }

        //static void Main(string[] args)
        //{
        //    Execute(Add, 4, 2);
        //    Execute(Sub, 4, 2);
        //}
    }
}