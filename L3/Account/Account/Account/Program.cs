using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            double NewBalance;
            string balance;
              
            Account1 a1 = new Account1();
            Console.WriteLine("your current balance is 500 : ");    
            Console.WriteLine("press d for deposit or press w for withdraw : ");

            balance = Console.ReadLine();

            if(balance=="d")
            {
                NewBalance = a1.Deposit();
                Console.WriteLine("your new balance is {0} : "+NewBalance);
            }
            if(balance=="w")
            {
                NewBalance = a1.Withdraw();
                Console.WriteLine("your new balance is {0} : " + NewBalance);
            }
            Console.ReadLine();
        }
    }
}
