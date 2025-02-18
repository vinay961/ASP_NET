using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    interface IReservable
    {
        void ReserveItem();
    }

    abstract class LibraryItem
    {
        public virtual void Borrow(string title)
        {
            Console.WriteLine($"Borrowing {title}.");
        }

        public virtual void Return(LibraryItem item)
        {
            Console.WriteLine($"Returning {item.GetType().Name}: {item.GetTitle()}");
        }

        public abstract void DisplayInfo();
        public abstract string GetTitle();  
    }

    class Book : LibraryItem, IReservable
    {
        private static int count = 0;
        private List<Book> books = new List<Book>();
        private List<string> reservationList = new List<string>(); 

        private string _title;
        private string _author;
        private string _isbn;
        private int _copiesAvailable;

        public Book(string title, string author, string isbn, int copiesAvailable)
        {
            _title = title;
            _author = author;
            _isbn = isbn;
            _copiesAvailable = copiesAvailable;
        }

        public override string GetTitle()
        {
            return _title;
        }

        public override void Borrow(string title)
        {
            foreach (Book book in books)
            {
                if (book._title == title && book._copiesAvailable > 0)
                {
                    book._copiesAvailable--;
                    count++;
                    Console.WriteLine($"Book '{book._title}' is borrowed. Copies left: {book._copiesAvailable}");
                    return;
                }
            }

            Console.WriteLine($"Book '{title}' is not available right now. Do you want to reserve it?");
        }

        public override void Return(LibraryItem item)
        {
            if (item is Book book)
            {
                book._copiesAvailable++;
                count--;
                Console.WriteLine($"Book '{book._title}' is returned. Copies now: {book._copiesAvailable}");

                if (reservationList.Count > 0)
                {
                    string firstInQueue = reservationList[0];
                    reservationList.RemoveAt(0);
                    Console.WriteLine($"Book '{book._title}' is now reserved for {firstInQueue}.");
                }
            }
        }

        public void ReserveItem()
        {
            Console.Write("Enter your name to reserve this book: ");
            string userName = Console.ReadLine();
            reservationList.Add(userName);
            Console.WriteLine($"Book '{_title}' is reserved for {userName}. You will be notified when it's available.");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{_title}, written by {_author}. ISBN: {_isbn}. Copies available: {_copiesAvailable}");
        }
    }

    class Magazine : LibraryItem
    {
        private string _title;
        private string _author;
        private int _copiesAvailable;

        public Magazine(string title, string author, int copiesAvailable)
        {
            _title = title;
            _author = author;
            _copiesAvailable = copiesAvailable;
        }

        public override string GetTitle()
        {
            return _title;
        }

        public override void Borrow(string title)
        {
            Console.WriteLine($"Magazines can't be borrowed! Title: {title}");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{_title}, written by {_author}. Copies available: {_copiesAvailable}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "12345", 2);
            Book book2 = new Book("1984", "George Orwell", "67890", 0); 

            book1.DisplayInfo();
            book1.Borrow("The Great Gatsby");
            book1.Return(book1);

            Console.WriteLine();

            book2.DisplayInfo();
            book2.Borrow("1984");
            book2.ReserveItem(); 
        }
    }
}
