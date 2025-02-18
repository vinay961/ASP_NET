using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task<string> Task1()
    {
        await Task.Delay(2000);
        return "Janhavi is cooking food.";
    }
    static async Task<string> Task2()
    {
        await Task.Delay(3000);
        return "Vinay is doing exercise.";
    }
    static async Task Main(string[] args)
    {
        Console.WriteLine("Exploring the house-> ");
        Task<string> task1 = Task1();
        Task<string> task2 = Task2();

        string[] res = await Task.WhenAll(task1, task2);
        Console.WriteLine(res[0]);
        Console.WriteLine(res[1]);

        Console.WriteLine("Doing other work");
    }
}

