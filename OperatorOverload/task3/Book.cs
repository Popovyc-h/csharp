namespace ListOfBooks;

internal class Book
{
    private string title;
    private string author;
    private int year;

    public string Title
    {
        get => title;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Invalud title");

            title = value;
        }

    }

    public string Author
    {
        get => author;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Invalud author");

            author = value;
        }
    }

    public int Year
    {
        get => year;
        set
        {
            if (value < 0 || value > 2025)
                throw new ArgumentException("Invalud year");

            year = value;
        }
    }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Book other)
            return false;

        if (Title == other.Title && Author == other.Author)
            return true;

        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Title, Author);
    }
}
