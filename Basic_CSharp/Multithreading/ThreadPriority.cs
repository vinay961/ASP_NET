
// ThreadPriority is an enumeration that represents the priority of a thread. The priority of a thread is used by the operating system to determine the order in which threads are scheduled. The priority of a thread can be set using the Priority property of the Thread class. The priority of a thread can be set to one of the following values: Highest, AboveNormal, Normal, BelowNormal, Lowest. The default priority of a thread is Normal.

namespace Multithreading
{
    class ThreadPriority
    {
        static long count1, count2;
        public static void IncrementCount1()
        {
            while (true)
            {
                count1++;
            }
        }
        public static void IncrementCount2()
        {
            while (true)
            {
                count2++;
            }
        }

        //static void Main(string[] args)
        //{
        //    Thread t1 = new Thread(IncrementCount1);
        //    Thread t2 = new Thread(IncrementCount2);
        //    t1.Start();
        //    t2.Start();

        //    Console.WriteLine("Main thread going to sleep.");
        //    Thread.Sleep(10000);
        //    Console.WriteLine("Main thread woke up.");

        //    t1.Abort();
        //    t2.Abort();

        //    t1.Join();
        //    t2.Join();

        //    Console.WriteLine("Count1: " + count1);
        //    Console.WriteLine("Count2: " + count2);

            // If we run the above code, both count1 and count2, will have different values but nearly equal. This is because both threads are running in parallel and incrementing the count variables. But what if we want to give priority to one thread over the other? We can achieve this using the Priority property of the Thread class.
            // We need to modify our above code like, 
            // t1.Priority = ThreadPriority.Highest;
            // t2.Priority = ThreadPriority.Lowest;
            // After that run the code, you will see that count1 will have a higher value than count2. This is because we have set the priority of t1 to Highest and the priority of t2 to Lowest. So, t1 will get more CPU time than t2 and hence count1 will have a higher value than count2.
        //}
    }
}
