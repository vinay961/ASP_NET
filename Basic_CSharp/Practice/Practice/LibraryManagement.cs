using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public interface IMedia
    {
        string Title { get; }
        void DisplayInfo();
    }

    public class SampleBook : IMedia
    {
        public string Title { get; }
        public SampleBook(string title) => Title = title;
        public void DisplayInfo() => Console.WriteLine($"Book: {Title}");
    }

    public class Magazine : IMedia
    {
        public string Title { get; }
        public Magazine(string title) => Title = title;
        public void DisplayInfo() => Console.WriteLine($"Magazine: {Title}");
    }

    public class ResearchPaper : IMedia
    {
        public string Title { get; }
        public ResearchPaper(string title) => Title = title;
        public void DisplayInfo() => Console.WriteLine($"Research Paper: {Title}");
    }

    public class Library<T> where T : IMedia
    {
        private List<T> items = new List<T>();
        public void Add(T item)
        {
            items.Add(item);
        }
        public void Remove(T item)
        {
            items.Remove(item);
        }

        public void DisplayItems()
        {
            foreach (var item in items)
            {
                item.DisplayInfo();
            }
        }
    }
    public static class Utility
    {
        public static bool FindItem<T>(List<T> list, T item) where T : IMedia
        {
            return list.Contains(item);
        }
    }
    public delegate T Operation<T>(T item1, T item2);

    public class TitleOperations
    {
        public static string CombineTitles(string title1, string title2)
        {
            return title1 + " & " + title2;
        }
    }

    public interface IMediaProducer<out T> where T : IMedia
    {
        T ProduceMedia();
    }

    public interface IMediaConsumer<in T> where T : IMedia
    {
        void ProcessMedia(T media);
    }

    public class DigitalLibrary<T> : Library<T> where T : IMedia
    {
        public void Download(T item)
        {
            Console.WriteLine($"Downloading {item.Title}...");
        }
    }

    public static class ReflectionHelper
    {
        public static void ShowGenericType<T>(T item)
        {
            Console.WriteLine($"The type of {item} is: {typeof(T)}");
        }
    }
    public static class DefaultValueHelper
    {
        public static T GetDefault<T>()
        {
            return default(T);
        }
    }

    class LibraryManagement
    {
        static void Main(string[] args)
        {
            Library<SampleBook> bookLibrary = new Library<SampleBook>();
            bookLibrary.Add(new SampleBook("C# for Beginners"));
            bookLibrary.Add(new SampleBook("Advanced C#"));

            List<SampleBook> books = new List<SampleBook> { new SampleBook("C#"), new SampleBook("Java") };
            Console.WriteLine("\nBook found: " + Utility.FindItem(books, new SampleBook("C#")));
                

            Console.WriteLine("Book Library:");
            bookLibrary.DisplayItems();
        }
    }
}
