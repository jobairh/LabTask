using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_library
{
    class Library
    {
        public string Name { get; set; }
        Book[] listOfBooks;

        public int totalBook { get; set; }

        public Library()
        {
            listOfBooks = new Book[100];
        }
        public Library(string name)
        {
            this.Name = name;
            listOfBooks = new Book[100];
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("totalBook: " + totalBook);
        }
        public void AddBook(params Book[] books)
        {
            foreach (var book in books)
            {
                if (totalBook < 100)
                    listOfBooks[totalBook++] = book;
            }
        }
        public void DeleteBook(Book book)
        {
            for (int i = 0; i < totalBook; i++)
            {
                if (book.Id.Equals(listOfBooks[i].Id))
                {
                    for (int j = i; j < totalBook - 1; j++)
                    {
                        listOfBooks[j] = listOfBooks[j + 1];
                    }
                    listOfBooks[totalBook] = null;
                    totalBook--;
                    break;
                }
            }
        }

        public void AddNewBookCopy(Book book, int copy)
        {
            book.AddBookCopy(copy);
        }
        public Book SearchBook(string id)
        {
            Book b = null;
            for (int i = 0; i < totalBook; i++)
            {
                if (listOfBooks[i].Id.Equals(id))
                {
                    b = listOfBooks[i];
                    break;
                }
            }
            return b;
        }
        public void ShowAllBooks()
        {
            for (int i = 0; i < totalBook; i++)
            {
                listOfBooks[i].ShowInfo();
            }
        }
    }
}
