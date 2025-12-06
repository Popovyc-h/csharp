using Library.Books;
using Library.Members;

namespace Library.Operations
{
    public class LibraryService
    {
        public List<Book> books = new List<Book>();
        public List<LibraryMember> members = new List<LibraryMember>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RegisterMember(LibraryMember member)
        {
            members.Add(member);
        }

        public void BorrowBook(string ticketNumber, string bookTitle)
        {
            Book foundBook = null;
            foreach (Book b in books)
            {
                if (b.title == bookTitle)
                {
                    foundBook = b;
                    break;
                }
            }

            LibraryMember foundMember = null;
            foreach (LibraryMember m in members)
            {
                if (m.ticketNumber == ticketNumber)
                {
                    foundMember = m;
                    break;
                }
            }

            if (foundBook != null && foundMember != null)
            {
                Console.WriteLine($"{foundMember.name} взяв книгу {foundBook.title}");
            }
            else
            {
                Console.WriteLine("Книгу не знайдено");
            }
        }

        public void ReturnBook(string bookTitle)
        {
            Book foundBook = null;
            foreach (Book b in books)
            {
                if (b.title == bookTitle)
                {
                    foundBook = b;
                    break;
                }
            }
            Console.WriteLine($"Книгу {bookTitle} повернуто");
        }
    }
}
