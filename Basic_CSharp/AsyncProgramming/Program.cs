using System;
using System.Threading.Tasks;

class Program
{
    public static async Task<int> DoWorkAsync(int a, int b)
    {
        Console.WriteLine("Task Started");
        await Task.Delay(3000);
        Console.WriteLine("Task Completed");
        return a + b;
    }

    public static async Task<string> DoAnotherWork(string name)
    {
        Console.WriteLine("Another Task Started");
        await Task.Delay(2000);
        Console.WriteLine("Another Task Completed");
        return name + " and JR.";
    }

    public static async Task DoAnotherWork1()
    {
        Console.WriteLine("Another-1 Task Started");
        await Task.Delay(2000);
        Console.WriteLine("Another-1 Task Completed");
    }

    static async Task Main(string[] args)
    {
        Console.WriteLine();

        // Start tasks but don't await them immediately
        Task<int> task1 = DoWorkAsync(2, 3);
        Task<string> task2 = DoAnotherWork("Vinay");
        Task task3 = DoAnotherWork1();

        // Do something else if needed...
        Console.WriteLine("Performing another task");

        // Await all tasks to complete
        int res1 = await task1;
        Console.WriteLine("Result: " + res1);
        Console.WriteLine();

        string res2 = await task2;
        Console.WriteLine("Result: " + res2);
        Console.WriteLine();

        await task3;
        Console.WriteLine();

        Console.WriteLine("Next Task Started");
    }
}
