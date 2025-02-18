using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericLibrary
{
    class Books
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public int Pages { get; set; }
        public int Year { get; set; }
        public string? Genre { get; set; }
    }

    class Programs
    {
        static void Main(string[] args)
        {
            List<Books> books = new List<Books>
            {
                new Books { Title = "The Hobbit", Author = "J.R.R. Tolkien", Pages = 310, Year = 1937, Genre = "Fantasy" },
                new Books { Title = "1984", Author = "George Orwell", Pages = 328, Year = 1949, Genre = "Dystopian" },
                new Books { Title = "To Kill a Mockingbird", Author = "Harper Lee", Pages = 281, Year = 1960, Genre = "Classic" },
                new Books { Title = "The Catcher in the Rye", Author = "J.D. Salinger", Pages = 277, Year = 1951, Genre = "Classic" },
                new Books { Title = "Brave New World", Author = "Aldous Huxley", Pages = 311, Year = 1932, Genre = "Dystopian" },
                new Books { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Pages = 180, Year = 1925, Genre = "Classic" },
                new Books { Title = "Moby Dick", Author = "Herman Melville", Pages = 635, Year = 1851, Genre = "Adventure" },
                new Books { Title = "Dune", Author = "Frank Herbert", Pages = 412, Year = 1965, Genre = "Sci-Fi" },
                new Books { Title = "The Fellowship of the Ring", Author = "J.R.R. Tolkien", Pages = 423, Year = 1954, Genre = "Fantasy" }
            };

            // 1. Find all books written by "J.R.R. Tolkien"
            var booksByTolkien = ;
            Console.WriteLine("Books by J.R.R. Tolkien:");
            foreach (var book in booksByTolkien)
            {
                Console.WriteLine("- " + book.Title);
            }

            // 2. Find books published after 1950
            var booksAfter1950 = books.Where(b => b.Year>1950);
            Console.WriteLine("\nBooks published after 1950:");
            foreach (var book in booksAfter1950)
            {
                Console.WriteLine("- " + book.Title);
            }

            // 3. Sort all books alphabetically by title
            var sortedBooks = /* Write LINQ Query */;
            Console.WriteLine("\nBooks sorted alphabetically:");
            foreach (var book in sortedBooks)
            {
                Console.WriteLine("- " + book.Title);
            }

            // 4. Find the book with the most pages
            var bookWithMostPages = /* Write LINQ Query */;
            Console.WriteLine($"\nBook with the most pages: {bookWithMostPages.Title} ({bookWithMostPages.Pages} pages)");

            // 5. Check if a book titled "Dune" exists
            bool isDuneExists = /* Write LINQ Query */;
            Console.WriteLine($"\nIs \"Dune\" in the collection? {(isDuneExists ? "Yes" : "No")}");

            // 6. Count how many books belong to the "Classic" genre
            int classicBookCount = /* Write LINQ Query */;
            Console.WriteLine($"\nNumber of Classic books: {classicBookCount}");

            // 7. Group books by genre and display them
            var groupedBooks = /* Write LINQ Query */;
            Console.WriteLine("\nBooks grouped by genre:");
            foreach (var group in groupedBooks)
            {
                Console.WriteLine($"- {group.Key}:");
                foreach (var book in group)
                {
                    Console.WriteLine($"  - {book.Title}");
                }
            }
        }
    }
}
