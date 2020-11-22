using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_library
{
    class Program
    {
        static void Main(string[] args)
        {
            Library l1 = new Library("AIUB Library");
            Book b1 = new Book("Padma nadir majhi", "Manik", "1001", 5);
            Book b2 = new Book("hazar bocor dhore", "zahir", "1002", 4);
            Book b3 = new Book("harry potter 1", "j.k", "1003", 4);
            Book b4 = new Book("harry potter 2", "j.k", "1004", 4);

            l1.AddBook(b1, b2, b3, b4);
            l1.ShowAllBooks();

            Book temp = l1.SearchBook("1004");
            if (temp != null)
            {
                l1.AddNewBookCopy(temp, 5);
            }
            Book b5 = new Book("C++ the complete reference", "herbert schildit", "1005", 10);
            l1.AddBook(b5);
            Console.WriteLine("----------------------");
            l1.ShowAllBooks();
       }
    }
}
