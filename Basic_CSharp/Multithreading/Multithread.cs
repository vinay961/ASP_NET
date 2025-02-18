
namespace Multithreading
{
    class Multithread
    {
        public static void func1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                if (i == 1)
                {
                    Console.WriteLine("Thread-1 is sleeping for 5 seconds!");
                    Thread.Sleep(5000);
                    Console.WriteLine("Thread-1 is wakeup after 5 seconds!");
                }
            }
            Console.WriteLine("First function work is finished.");
        }
        public static void func2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Second function work is finished.");
        }
        public static void func3(object max)
        {
            int number = Convert.ToInt32(max);
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Third function work is finished.");
        }

        //static void Main()
        //{ 
        //    Thread thread = Thread.CurrentThread;
        //    thread.Name = "Main Thread";
        //    Console.WriteLine(thread.Name + " starting");

        //    ThreadStart threadStart = new ThreadStart(func1); // ThreadStart is a delegate that represents a method that does not take any parameter and does not return any value.
        //    Thread t1 = new Thread(threadStart); // after creating the instance of ThreadStart delegate, we pass it to the Thread class constructor.
        //    Thread t2 = new Thread(func2); // We can also pass the function name directly to the Thread class constructor, but when we took parameter in the function then we can't pass the function name directly to the Thread class constructor.
        //    // t1.Start();
        //    // t2.Start();
        //    ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(func3);
        //    Thread t3 = new Thread(parameterizedThreadStart);
        //    t3.Start(10); // here we pass the parameter to the function using the Start() method, but it is not type safe. We can pass any type of parameter to the function using the Start() method.
        //    Console.WriteLine(thread.Name + " stopped");
        //}
    }
}


// In the above code, we can see that the main thread is executing the func1() and func2() methods. The func1() method is paused for 5 seconds using the Sleep() method. During this time, the main thread is executing the func2() method. This is an efficient way of using threads. The main thread is existing after executing all the methods.

// As we can observe that we directly pass the function name as a parameter to the Thread class constructor, but the process is something different. The Thread class constructor takes a parameter of type ThreadStart delegate. The ThreadStart delegate is a built-in delegate that is defined in the System namespace. It is used to represent a method that does not take any parameter and does not return any value. The ThreadStart delegate is used to pass the method name to the Thread class constructor. The Thread class constructor creates a new thread that executes the method passed as a parameter to the constructor. The Start() method is used to start the thread. 

// What we have done above is also correct, the CLI internally create the instance of that delegate and pass it to the constructor. The CLI does this automatically, so we don't need to create the instance of the delegate explicitly. The CLI automatically creates the instance of the delegate and passes it to the constructor. This is the reason why we can directly pass the function name as a parameter to the Thread class constructor
