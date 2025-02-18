using System.Diagnostics;
using System.Xml.Serialization;

namespace Multithreading
{
    class SingleVsMulti
    {
        public static void Display()
        {
            int count = 0;
            for(int i = 0; i < 1000000000; i++)
            {
                count++;
            }
        }
        public static void Display2()
        {
            int count = 0;
            for (int i = 0; i < 1000000000; i++)
            {
                count++;
            }
        }
        static void Main(string[] args)
        {
            // here let's check that how much time time is taken by single thread
            Stopwatch s = new Stopwatch();
            s.Start();
            Display();
            Display2();
            s.Stop();
            Console.WriteLine("Time taken by single thread: " + s.ElapsedMilliseconds);

            // Now let's check the time taken by multi thread
            Stopwatch s1 = new Stopwatch();
            s1.Start();
            Thread t1 = new Thread(Display);
            Thread t2 = new Thread(Display2);
            t1.Start();
            t2.Start();
            t1.Join(); // why we are using join here? because we want to wait for the completion of the thread t1 and t2, if we don't use join, then the main thread will not wait for the completion of t1 and t2 and it will print the time taken by multi thread before the completion of t1 and t2.
            t2.Join();
            s1.Stop();
            Console.WriteLine("Time taken by multi thread: " + s1.ElapsedMilliseconds);
        }
    }
}
