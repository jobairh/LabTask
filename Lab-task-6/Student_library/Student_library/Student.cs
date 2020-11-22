﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_library
{
    class Student
    {
        public String Name { get; set; }

        public String Id { get; set; }

        Borrow[] borrows;

        public int BorrowCount { get; set; }

        public Student()
        {
            borrows = new Borrow[100];
        }
        //Book[] borrows;
        //public int BorrowCount { get; set; }
        //public int Date { get; set; }

        public Student(string name, string id)
        {
            Name = name;
            Id = id;
            //borrows = new Book[5];
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Id: " + Id);
        }
        public void AddBorrow(Borrow borrow)
        {
            borrows[BorrowCount++] = borrow;
        }
        public void ShowAllBorrows()
        {
            for (int i = 0; i < BorrowCount; i++)
            {
                borrows[i].ShowAllBooks();
            }
        }
    }
}