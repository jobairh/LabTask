using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle1
    {
        private int side1;
        private int side2;
        private int side3;

        public int Side1
        {
            get { return side1; }
            set { side1 = value; }
        }
        public int Side2
        {
            get { return side2; }
            set { side2 = value; }
        }
        public int Side3
        {
            get { return side3; }
            set { side3 = value; }
        }
        public Triangle1() { }

        public Triangle1(int side1,int side2,int side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Please enter three sides of a Triangle : ");
            Console.WriteLine("1st side: "+Side1);
            Console.WriteLine("2nd side: "+Side2);
            Console.WriteLine("3rd side: "+Side3);
        }

    }
}
