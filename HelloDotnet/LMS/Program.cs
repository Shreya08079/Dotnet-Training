using System;
using System.Collections.Generic;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int PublicationYear { get; set; }
}

public class LibraryUtility
{
    
    private SortedDictionary<int, Book> _books = new SortedDictionary<int, Book>();
    private int _bookId = 1;

    public void AddBook(string title, string author, string genre, int year)
    {
        Book book = new Book()
        {
            Id = _bookId,
            Title = title,
            Author = author,
            Genre = genre,
            PublicationYear = year
        };

        _books.Add(_bookId, book);
        _bookId++;
    }

    public SortedDictionary<string, List<Book>> GroupBooksByGenre()
    {
        SortedDictionary<string, List<Book>> result =
            new SortedDictionary<string, List<Book>>();

        foreach (var book in _books.Values)
        {
            if (!result.ContainsKey(book.Genre))
            {
                result[book.Genre] = new List<Book>();
            }

            result[book.Genre].Add(book);
        }

        return result;
    }

    public List<Book> GetBooksByAuthor(string author)
    {
        List<Book> authorBooks = new List<Book>();

        foreach (var pair in _books)
        {
            Book book = pair.Value;

            if (book.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
            {
                authorBooks.Add(book);
            }
        }

        return authorBooks;
    }

    public int GetTotalBooksCount()
    {
        return _books.Count;
    }
}

public class Program
{
    public static void Main()
    {
        LibraryUtility library = new LibraryUtility();

        library.AddBook("The Hobbit", "J.R.R. Tolkien", "Fiction", 1937);
        library.AddBook("Sherlock Holmes", "Arthur Conan Doyle", "Mystery", 1892);
        library.AddBook("Atomic Habits", "James Clear", "Non-Fiction", 2018);
        library.AddBook("LOTR", "J.R.R. Tolkien", "Fiction", 1954);

        Console.WriteLine("Books Grouped By Genre:");
        var grouped = library.GroupBooksByGenre();

        foreach (var genre in grouped)
        {
            Console.WriteLine($"\nGenre: {genre.Key}");

            foreach (var book in genre.Value)
            {
                Console.WriteLine(
                    $"ID: {book.Id}, Title: {book.Title}, Author: {book.Author}, Year: {book.PublicationYear}"
                );
            }
        }

        Console.WriteLine("\nBooks By Author (J.R.R. Tolkien):");
        var authorBooks = library.GetBooksByAuthor("J.R.R. Tolkien");

        foreach (var book in authorBooks)
        {
            Console.WriteLine($"{book.Title} ({book.PublicationYear})");
        }

        Console.WriteLine($"\nTotal Books: {library.GetTotalBooksCount()}");
    }
}
