
// previously we discuss that passing parameter using start method to parameterized constructor of thread class is not type safe. To make it type safe we use lambda expression.
// we also see that main thread is not waiting for the child thread to complete its execution. To make main thread wait for child thread to complete its execution we use join method.

namespace Multithreading
{
    class multithread1
    {
        public void sample1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Sample-1 running for " + i + " times");
                if (i == 3)
                {
                    Thread.Sleep(1000);
                }
            }
        }
        public void sample2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Sample-2 running for " + i + " times");
            }
        }

        //static void Main(string[] args)
        //{
        //    Thread thread = Thread.CurrentThread;
        //    thread.Name = "Main Thread";
        //    Console.WriteLine(thread.Name + " starting");
        //    multithread1 obj = new multithread1();
        //    Thread t1 = new Thread(obj.sample1);
        //    t1.Start();
        //    t1.Join();
        //    Thread t2 = new Thread(obj.sample2);
        //    t2.Start();
        //    t2.Join(); // join also except a parameter of time in millisecond, it means that main thread wait for child thread to complete in that particular time period.
        //    Console.WriteLine(thread.Name + " stopping");
        //}
    }
}
