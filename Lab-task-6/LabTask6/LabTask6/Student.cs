using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask6
{
    class Student:Person
    {
        private String name;
        private String id;
        private String department;
        private float cgpa;

        public Student()
        {
            Console.WriteLine("student default");
        }
        public Student(string name,string id,string department,float cgpa) :base(name,id)
        {
            Console.WriteLine("student 2 parameter");
            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;
        }


    }
}
