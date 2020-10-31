using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Id = "17-34940-2";
            s1.Name = "Jobair hossain";
            s1.Cgpa = 4;
            s1.Department = "Cse";
            Console.WriteLine(s1.Id);
            Console.WriteLine(s1.Name);
            Console.WriteLine(s1.Cgpa);
            Console.WriteLine(s1.Department);

        }
    }
}
