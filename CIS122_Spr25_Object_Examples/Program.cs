
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Object Examples");

        Library library = new Library();

        Book mobyDick = new Book("Moby Dick","12345");
        Book textBook = new Book("C# Players Guide", "RB Whitacre", "98765", 2023);

        library.AddBook(mobyDick);
        library.AddBook(textBook);

        List<string> cardSuit = new List<string>();
        cardSuit.Add("Hearts");
        cardSuit.Add("Clubs");
        cardSuit.Add("Diamonds");
        cardSuit.Add("Spades");

        foreach (string suit in cardSuit)
        {
            Console.WriteLine(suit);
        }

        foreach(Book book in library._books)
        {

        }


    }
}

public class Person
{

    public string _name;
    public int _age;
    public string _ssn;

    public Person(string name, int age, string ssn)
    {
        _name = name;
        _age = age;
        _ssn = ssn;
    }

    public Person() : this("John Doe", -1, "000-00-0000")
    {
    }
}

public class Book
{
    public string _title;
    public string _author;
    public string _isbn;
    public int _publicationDate;

    public Book(string title, string isbn) : this (title, string.Empty, isbn, -1)
    {
    }

    public Book(string title, string author, string isbn, int pubDate)
    {
        _title = title;
        _author = author;
        _isbn = isbn;
        _publicationDate = pubDate;
    }
}

public class Library
{
    public List<Book> _books;
    
    public Library()
    {
        _books = new List<Book>();
    }

    public void AddBook(Book newBook)
    {
        _books.Add(newBook);
    }
}


