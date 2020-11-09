using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask6
{
    class Library
    {
        private String libName;
        private String libAddress;
        private Book[] listOfBook;
        private int totalBook;

        public Library()
        {
            Console.WriteLine("Library default");
        }
        public Library(string libName,string libAddress,Book[] listOfBook, int totalBook)
        {
            Console.WriteLine("Library 2 parameter");
            this.libName = libName;
            this.libAddress = libAddress;
            this.listOfBook = listOfBook;
            this.totalBook = totalBook;
        }

 
    }
}
