using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Student
    {
        private string name;
        private string id;
        private string department;
        private float cgpa;

        public string Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Department
        {
            set { department = value; }
            get { return department; }
        }
        public float Cgpa
        {
            set { cgpa = value; }
            get { return cgpa; }
        }
        public Student() { }
        public Student(string id,string name,string department,float cgpa)
        {
            this.id = id;
            this.name = name;
            this.department = department;
            this.cgpa = cgpa;
        }
        public void showInfo()
        {
            Id = "17-34940-2";
            Name = "Jobair hossain";
            Department = "Cse";
            Cgpa = 4;

        }
    }
}
