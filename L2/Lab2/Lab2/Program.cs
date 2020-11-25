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
            /*program-1:Write a program to print all even numbers from 1 to n 
             * using for loop. 

            int i, n, sum = 0;
            System.Console.WriteLine("input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("The even numbers are : ");
            for(i=1;i<=n;i++)
            {
                System.Console.WriteLine(2 * i);
            }
            */

            /*program-2:
            //Write a program to print the following pattern using loop.

            //X0X0X0 
            //0X0X0X 
            //X0X0X0 
            //0X0X0X
                        
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
            */

            /*
            //program-4:Write a program to print the sum of odd and even numbers
            //starting from 1 to 100.

            int i, start, end, even_sum = 0, odd_sum=0;

            // Input range to find sum of even and odd numbers 
            System.Console.WriteLine("Enter lower limit : ");
            start = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter upper limit : ");
            end = Convert.ToInt32(Console.ReadLine());

            // Iterate from start to end and find sum 
            for (i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {

                    even_sum = even_sum + i;
                }
                else
                {
                    odd_sum = odd_sum + i;
                }
            }  
            System.Console.WriteLine("Sum of even numbers between 1 to 100: " + even_sum);
                
            System.Console.WriteLine("Sum of odd numbers between 1 to 100: " + odd_sum);

            */

            /*
            //program-6:Write a program to find out factorial of a number.
            //Example factorial of 5 is 1 * 2 * 3 * 4 * 5

            int i, n, fact=1;
            System.Console.WriteLine("Enter an integer : ");
            n = Convert.ToInt32(Console.ReadLine());

            for(i=1;i<=n;i++)
            {
                fact = fact * i;
            }
            System.Console.WriteLine("factorial of 5 is : "  +fact);
            */

            /*
            //program-7:Print the pattern below.
            //*
            //**
            //***
            //****
            //*****
            //****
            //***
            //**
            //*

            int i, j, n, columns = 1;

            System.Console.WriteLine("Enter number of columns : ");
            n = Convert.ToInt32(Console.ReadLine());

            for(i=1;i<n*2;i++)
            {
                for(j=1;j<=columns;j++)
                {
                    System.Console.Write("*");
                }
                if (i < n)
                {
                    columns++;
                }
                else
                {

                    columns--;
                }
                System.Console.Write("\n");
            }
            */

            //program-5: Write a program to print the given number pattern using loop.
            //1
            // 2
            //  3
            //   4
            //    5
           
            int i, j, k, n;
            printf(“Enter the Number: “);
            scanf(“% d”, &n);
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    if (i == j)
                        printf(“* “);
                    else
                        printf(”  “);
                }
                printf(“n“);
            }
            //
        }
    }
}
           

       
  
    


