using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle1 t1 = new Triangle1(  );
            //t1.ShowInfo();
            Console.WriteLine("Please enter three sides of a Triangle : ");
            t1.Side1 = Convert.ToInt32(Console.ReadLine());
            t1.Side2 = Convert.ToInt32(Console.ReadLine());
            t1.Side3 = Convert.ToInt32(Console.ReadLine());

            if (t1.Side1 == t1.Side2 && t1.Side2 == t1.Side3 && t1.Side3 == t1.Side1)
            {
                Console.WriteLine("this is an Equilateral Triangle");
            }
            else if (t1.Side1 == t1.Side2 || t1.Side2 == t1.Side3 || t1.Side3 == t1.Side1)
                    {
                Console.WriteLine("this is an Isosceles Triangle");
            }
            else
            {
                Console.WriteLine("this is an Scalene Triangle");

            }

        }
    }
}
