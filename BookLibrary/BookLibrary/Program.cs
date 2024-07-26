using BookLibrary;
using System;

class Booklibrary
{
    static void Main(string[] args)
    {
        List<Book> books = new List<Book>
        {
    new Book { Id = 1, Title = "C# in Depth", Author = "Jon Skeet", Year = 2019, CopiesAvailable = 5 },
    new Book { Id = 2, Title = "Pro C# 7", Author = "Andrew Troelsen", Year = 2018, CopiesAvailable = 2 },
    new Book { Id = 3, Title = "C# 6.0 and the .NET 4.6 Framework", Author = "Andrew Troelsen", Year = 2015, CopiesAvailable = 0 },
    new Book { Id = 4, Title = "Learning C# by Developing Games", Author = "Harrison Ferrone", Year = 2020, CopiesAvailable = 4 },
    new Book { Id = 5, Title = "CLR via C#", Author = "Jeffrey Richter", Year = 2012, CopiesAvailable = 1 }
        };

        var booksByAndrewTroelsen = books.Where(b => b.Author == "Andrew Troelsen").ToList();
        Console.WriteLine("Carti de Andrew Troelsen:");
        foreach (var book in booksByAndrewTroelsen)
        {
            Console.WriteLine($"{book.Title}");
        }

        var booksOrderedByYearDesc = books.OrderByDescending(b => b.Year).ToList();
        Console.WriteLine("Carti ordonate descrescator dupa anul publicarii:");
        foreach (var book in booksOrderedByYearDesc)
        {
            Console.WriteLine($"-{book.Title} ({book.Year})");
        }

        var availableBookTitles = books.Where(b => b.CopiesAvailable > 0).Select(b => b.Title).ToList();
        Console.WriteLine("Titluri de carti disponibile:");
        foreach (var title in availableBookTitles)
        {
            Console.WriteLine($"{title}");
        }

        var totalCopiesAvailable = books.Sum(b => b.CopiesAvailable);
        Console.WriteLine($"Numarul total de copii disponibile: {totalCopiesAvailable}");

        var uniqueAuthors = books.Select(b => b.Author).Distinct().ToList();
        Console.WriteLine("Autori unici:");
        foreach (var author in uniqueAuthors)
        {
            Console.WriteLine($"{author}");
        }

        var secondPageBooks = books.OrderBy(b => b.Title).Skip(2).Take(2).ToList();
        Console.WriteLine("A doua pagina de rezultate (2 carti pe pagina, ordonate dupa titlu):");
        foreach (var book in secondPageBooks)
        {
            Console.WriteLine($"{book.Title}");
        }
    }


}