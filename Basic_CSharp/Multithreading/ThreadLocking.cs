
// In multithreading environment, multiple threads can access the same resource. If multiple threads try to modify the same resource, it may lead to data inconsistency. To avoid this problem, we use thread-locking. Thread-locking is a mechanism that allows only one thread to access the resource at a time. It is used to prevent data inconsistency in multithreading environment.


namespace Multithreading
{
    class ThreadLocking
    {
        public void Display()
        {
            lock (this)
            { // lock keyword is used to lock the resource. It allows only one thread to access the resource at a time.
                Console.Write("CSharp is an ");
                Thread.Sleep(5000);
                Console.WriteLine("Object Oriented Language.");
            }
        }
        // static void Main(string[] args)
        // {
            //ThreadLocking obj = new ThreadLocking();
            //Thread t1 = new Thread(obj.Display);
            //Thread t2 = new Thread(obj.Display);
            //Thread t3 = new Thread(obj.Display);
            //t1.Start();
            //t2.Start();
            //t3.Start();
            // If we run the above code, it generates the output like:
            // CSharp is an CSharp is an CSharp is an Object Oriented Language.Object Oriented Language.Object Oriented Language.
            // Now the question arises, why the output is not "CSharp is an Object Oriented Language."?
            // The reason is that multiple threads are accessing the same resource at the same time. When one thread is writing the data, another thread is also writing the data. This leads to data inconsistency.

        // }
    }
}
