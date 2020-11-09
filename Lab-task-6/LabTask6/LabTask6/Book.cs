using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask6
{
    class Book
    {
        private String bookName;
        private String bookAuthor;
        private String bookId;
        private String bookType;
        private int bookCopy;

        public Book()
        {
            Console.WriteLine("book default");
        }  
        public Book(String bookName, String bookAuthor, String bookId, String bookType, int bookCopy)
        {
            Console.WriteLine("book 2 parameter");
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookType = bookType;
            this.bookCopy = bookCopy;
        }



    }
}
