using Library.Members;

namespace Library.Members
{
    public class LibraryMember
    {
        public string name { get; set; }
        public string ticketNumber { get; set; }

        public LibraryMember(string name, string ticketNumber)
        {
            this.name = name;
            this.ticketNumber = ticketNumber;
        }
    }
}
