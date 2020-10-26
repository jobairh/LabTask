using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*program-1:

            int i, n, sum = 0;
            System.Console.WriteLine("input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("The even numbers are : ");
            for(i=1;i<=n;i++)
            {
                System.Console.WriteLine(2 * i);
            }
            */
            //program-2:
            //Write a program to print the following pattern using loop.

            //X0X0X0 
            //0X0X0X 
            //X0X0X0 
            //0X0X0X
            /* C program to print solid rectangle star pattern */



            /* Function to print solid rectangle*/

            

            

                int i, j,rows, columns;

            System.Console.WriteLine("Enter the number of rows: ");

            rows = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("\nEnter the number of columns: ");

            columns = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= rows; i++)

                {

                    for (j = 1; j <= columns; j++)

                    {

                     System.Console.Write("X0");

                    }

                System.Console.Write("\n");

                }

            }


        }
    }
    


