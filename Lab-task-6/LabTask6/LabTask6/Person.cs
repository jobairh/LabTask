using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask6
{
    class Person
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string department;

        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        private float cgpa;

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        public Person()
        {
            Console.WriteLine("person default");
        }
        public Person(string name)
        {
            Console.WriteLine("parameter 1 constractor");
            this.name = name;
        }
        public Person(string name, string id)
        {
            Console.WriteLine("parameter 2 constractor");
            this.name = name;
            this.id = id;
        }
        public Person(string name, string id, string department, float cgpa)
        {
            Console.WriteLine("parameter 3 constractor");
            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Id : " + Id);
            Console.WriteLine("Department : " + department);
            Console.WriteLine("Cgpa : " + cgpa);
        }
    }
}
