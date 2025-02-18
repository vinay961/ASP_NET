using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    interface IBookActions
    {
        void Borrow();
        void Return();
    }
    interface IPrintable
    {
        void PrintDetails();
    }

    class BookTitleComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Title.CompareTo(y.Title);
        }
    }
    class Book : IBookActions, IPrintable
    {
        public string? Title { get; }
        public string? Author { get; }

        public Book(string? title, string? author)
        {
            Title = title;
            Author = author;
        }
        public void Borrow()
        {
            Console.WriteLine($"Borrowing '{Title}'...");
        }
        public void Return()
        {
            Console.WriteLine($"Returning '{Title}'...");
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}");
        }
    }
    class Interface
    {
        //static void Main(string[] args)
        //{
        //    List<Book> books = new List<Book>
        //    {
        //        new Book("Java Fundamentals", "John Doe"),
        //        new Book("C# Programming", "Jane Smith"),
        //        new Book("Python Basics", "Alice Brown")
        //    };
        //    List<IBookActions> actions = new List<IBookActions>(books);
        //    foreach (IBookActions book in books)
        //    {
        //        book.Borrow();
        //        book.Return();
        //        // book.PrintDetails(); // can't call it because IBookActions interface doesn't contain it
        //    }

        //    Console.WriteLine("\nBooks Before Sorting:");
        //    foreach (var book in books)
        //    {
        //        book.PrintDetails();
        //    }

        //    books.Sort(new BookTitleComparer());

        //    Console.WriteLine("\nBooks After Sorting:");
        //    foreach (var book in books)
        //    {
        //        book.PrintDetails();
        //    }
        //}
    }
}
