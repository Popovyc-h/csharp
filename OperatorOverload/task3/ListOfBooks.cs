namespace ListOfBooks;

internal class ListOfBooks
{
    private List<Book> books = new List<Book>();

    public int count => books.Count;

    public Book Add(Book book)
    {
        if (book == null)
            throw new ArgumentNullException(nameof(book));
        if (Contains(book))
            throw new ArgumentException("Book already exists");

        books.Add(book);
        return book;
    }

    public bool Contains(Book book)
    {
        return books.Contains(book);
    }

    public bool Remove(Book book)
    {
        if (book == null)
            throw new ArgumentNullException(nameof(book));

        return books.Remove(book);
    }

    public Book this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
                throw new ArgumentOutOfRangeException(nameof(index));
            return books[index];
        }
        set
        {
            if (index < 0 || index >= count)
                throw new ArgumentOutOfRangeException(nameof(index));
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            books[index] = value;
        }
    }

    public static ListOfBooks operator +(ListOfBooks list, Book book)
    {
        if (book == null)
            throw new ArgumentNullException(nameof(book));
        if(list == null)
            throw new ArgumentNullException(nameof(list));

        list.Add(book);
        return list;
    }

    public static ListOfBooks operator -(ListOfBooks list, Book book)
    {
        if (book == null)
            throw new ArgumentNullException(nameof(book));
        if (list == null)
            throw new ArgumentNullException(nameof(list));

        list.Remove(book);
        return list;
    }


}
