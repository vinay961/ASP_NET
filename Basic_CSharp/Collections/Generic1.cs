using System;

namespace Collections
{
    class Generic1<T>
    {
        public void Add(T x, T y)
        {
            dynamic dx = x;
            dynamic dy = y;
            Console.WriteLine(dx + dy);
        }
        public void Sub(T x, T y)
        {
            dynamic dx = x;
            dynamic dy = y;
            Console.WriteLine(dx - dy);
        }
        public void Mul(T x, T y)
        {
            dynamic dx = x;
            dynamic dy = y;
            Console.WriteLine(dx * dy);
        }
        public void Div(T x, T y)
        {
            dynamic dx = x;
            dynamic dy = y;
            if (dy == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return;
            }
            Console.WriteLine(dx / dy);
        }

        //static void Main()
        //{
        //    var g = new Generic1<int>();
        //    g.Add(1, 2);
        //    g.Sub(1, 2);
        //    g.Mul(1, 4);
        //    g.Div(4, 2);  // Added missing call
        //}
    }
}
