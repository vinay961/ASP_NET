
namespace Practice
{
    public class TaskProcessor
    {
        public async Task ProcessTaskAsync(string taskName, int duration)
        {
            Console.WriteLine($"{taskName} started on thread {Thread.CurrentThread.ManagedThreadId}");
            await Task.Delay(duration);
            Console.WriteLine($"{taskName} completed.");
        }

        public async Task RunTasksAsync()
        {
            Task task1 = ProcessTaskAsync("Task 1", 3000);
            Task task2 = ProcessTaskAsync("Task 2", 2000);
            Task task3 = ProcessTaskAsync("Task 3", 1000);

            await Task.WhenAll(task1, task2, task3);

            Console.WriteLine("All tasks completed.");
        }
    }
    class MultiThreadingDemo
    {
        //static async Task Main()
        //{
        //    TaskProcessor processor = new TaskProcessor();
        //    await processor.RunTasksAsync();
        //}
    }
}
