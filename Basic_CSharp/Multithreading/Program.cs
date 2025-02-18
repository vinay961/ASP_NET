// Operating system: It is a system software that manages computer hardware and software resources and provides common services for computer programs.
// Process: It is an instance of a computer program that is being executed. In simple terms, it is a program under execution.
// Thread: In simple terms thread is a unit used to execute the code of every application.By default, every application has at least one thread that is known as Main thread. So every program is by default a single-threaded model.

// Thread class is used to create and manage threads in multithreading environment. It provides constructors and methods to create and control the behavior of a thread.

class Program
{
    public static void sample1()
    {
        Console.WriteLine("Sample-1 method!");
        Thread.Sleep(5000); // Sleep is a static method of Thread class that is used to suspend the current thread for a specified amount of time.
    }
    public static void sample2()
    {
        Console.WriteLine("Sample-2 method!");
    }
    public static void sample3()
    {
        Console.WriteLine("Sample-3 method!");
    }
    //static void Main()
    //{
    //    Thread t = Thread.CurrentThread; // CurrentThread is a static property of Thread class that returns the thread that is currently executing
    //    t.Name = "Main Thread"; // Name is a property of Thread class that is used to get or set the name of the thread
    //    Console.WriteLine("This is {0}", t.Name);
    //    sample1();
    //    sample2();
    //    sample3();
    //    Console.WriteLine(t.Name + "is existing.");
    //}
}

// Above we can observe that the main thread is executing the sample1(), sample2() and sample3() methods. The sample1() method is paused for 5 seconds using the Sleep() method. The sample2() and sample3() methods are executed without any pause. The main thread is existing after executing all the methods.
// The Problem with the above code is that the sample1() method is paused for 5 seconds. During this time, the main thread is paused and it is not executing any other methods. This is not an efficient way of using threads.