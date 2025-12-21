namespace ListOfBooks;

internal class Program
{
    static void Main(string[] args)
    {
        var myList = new ListOfBooks();

        var book1 = new Book("1984", "George Orwell", 1949);
        myList.Add(book1);
        
        myList = myList + new Book("Кобзар", "Тарас Шевченко", 1840);

        Console.WriteLine($"Кількість книг: {myList.count}");

        Console.WriteLine($"Перша книга: {myList[0].Title}");
    }
}
