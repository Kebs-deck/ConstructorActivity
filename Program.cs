using System;

public class Book
{
    private string title;
    private string author;
    private int yearPublished;
    private string genre;

    public Book()
    {
        title = "Unknown";
        author = "Unknown";
        yearPublished = 0;
        genre = "Unknown";
    }

    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
        yearPublished = 0;
        genre = "Unknown";
    }

    public Book(string title, string author, int yearPublished)
    {
        this.title = title;
        this.author = author;
        this.yearPublished = yearPublished;
        genre = "Unknown";
    }

    public Book(string title, string author, int yearPublished, string genre)
    {
        this.title = title;
        this.author = author;
        this.yearPublished = yearPublished;
        this.genre = genre;
    }

    public void DisplayBookInfo()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Year Published: {yearPublished}");
        Console.WriteLine($"Genre: {genre}");
    }

    public static void Main()
    {
        Book book1 = new Book();
        Book book2 = new Book("1984", "George Orwell");
        Book book3 = new Book("To Kill a Mockingbird", "Harper Lee", 1960);
        Book book4 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925, "Fiction");

        Console.WriteLine("---Book 1: Default Construction---");
        book1.DisplayBookInfo();
        Console.WriteLine();

        Console.WriteLine("---Book 2: Basic Construction---");
        book2.DisplayBookInfo();
        Console.WriteLine();

        Console.WriteLine("---Book 3: Detailed Construction---");
        book3.DisplayBookInfo();
        Console.WriteLine();

        Console.WriteLine("---Book 4: Complete Construction---");
        book4.DisplayBookInfo();
    }
}
