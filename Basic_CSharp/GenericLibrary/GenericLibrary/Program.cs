using System;
using System.Collections.Generic;

namespace GenericLibrary
{
    // Delegate for notifications
    public delegate void LibraryNotification(string msg);

    // Generic Repository for Library Items
    class LibraryRepository<T>
    {
        private List<T> items = new List<T>();

        // Events for issuing and returning items
        public event LibraryNotification? OnItemIssued;
        public event LibraryNotification? OnItemReturned;

        // Add an item to the library
        public void AddItem(T item)
        {
            items.Add(item);
            Console.WriteLine($"{item} added to library.");
        }

        // Remove an item from the library
        public void RemoveItem(T item)
        {
            if (items.Contains(item))
            {
                items.Remove(item);
                Console.WriteLine($"{item} removed from library.");
            }
            else
            {
                Console.WriteLine("Item not found in library!");
            }
        }

        // Borrow an item
        public void Borrow(T item)
        {
            if (items.Contains(item))
            {
                items.Remove(item);
                Console.WriteLine($"{item} is issued.");
                OnItemIssued?.Invoke($"{item} has been borrowed.");
            }
            else
            {
                Console.WriteLine("Item not available for borrowing.");
            }
        }

        // Return an item
        public void Return(T item)
        {
            items.Add(item);
            Console.WriteLine($"{item} is returned.");
            OnItemReturned?.Invoke($"{item} has been returned.");
        }

        // Display all items in library
        public void DisplayAll()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("No items in the library.");
                return;
            }

            Console.WriteLine("Library Items:");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }

    // Book class
    class Book
    {
        public string Title { get; }
        public string Author { get; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        // Override ToString() to print book details
        public override string ToString()
        {
            return $"Book: {Title} by {Author}";
        }
    }

    // Magazine class
    class Magazine
    {
        public string Title { get; }
        public string Editor { get; }

        public Magazine(string title, string editor)
        {
            Title = title;
            Editor = editor;
        }

        // Override ToString() to print magazine details
        public override string ToString()
        {
            return $"Magazine: {Title}, Edited by {Editor}";
        }
    }

    class Program
    {
        // Event Handlers
        public static void ItemIssueHandler(string msg)
        {
            Console.WriteLine($"[Notification] {msg}");
        }

        public static void ItemReturnedHandler(string msg)
        {
            Console.WriteLine($"[Notification] {msg}");
        }

        static void Main(string[] args)
        {
            // Create library repository for books
            LibraryRepository<Book> bookRepo = new LibraryRepository<Book>();

            // Subscribe to events
            bookRepo.OnItemIssued += ItemIssueHandler;
            bookRepo.OnItemReturned += ItemReturnedHandler;

            // Create book instances
            Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");

            // Add books to library
            bookRepo.AddItem(book1);
            bookRepo.AddItem(book2);

            // Display all books
            bookRepo.DisplayAll();

            // Borrow a book
            bookRepo.Borrow(book1);

            // Return a book
            bookRepo.Return(book1);

            // Display all books again
            bookRepo.DisplayAll();

            LibraryRepository<Magazine> magazine = new LibraryRepository<Magazine>();
            // Create magazine instance
            Magazine magazine1 = new Magazine("The Silent Killer", "Vinay");
            Magazine magazine2 = new Magazine("The College time", "Janhavi");

            // Add magazine to library
            magazine.AddItem(magazine1);
            magazine.AddItem(magazine2);

            // Display all magazine
            magazine.DisplayAll();

        }
    }
}
