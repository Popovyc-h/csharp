using Library.Books;
using Library.Members;
using Library.Operations;

namespace LibraryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryService library = new LibraryService();

            Book book1 = new Book("Кобзар", "Тарас Шевченко", "Поезія");
            Book book2 = new Book("Лісова пісня", "Леся Українка", "Драма");
            Book book3 = new Book("Захар Беркут", "Іван Франко", "Повість");

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            LibraryMember member1 = new LibraryMember("Міша", "1");
            LibraryMember member2 = new LibraryMember("Вася", "2");
            LibraryMember member3 = new LibraryMember("Вітя", "3");

            library.RegisterMember(member1);
            library.RegisterMember(member2);
            library.RegisterMember(member3);

            library.BorrowBook("1", "Кобзар");
            library.BorrowBook("2", "Захар Беркут");
            library.BorrowBook("3", "Букварик");
            Console.WriteLine();
            library.ReturnBook("Кобзар");
            library.ReturnBook("Захар Беркут");
        }
    }
}
