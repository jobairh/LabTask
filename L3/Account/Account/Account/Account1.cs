using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Account1
    {
        private string accName;
        private string acid;
        private int balance;

        public string Accname
        {
            get { return accName; }
            set { accName = value; }

        }
        public string Acid
        {
            get { return acid; }
            set { acid = value; }
        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public Account1() 
        {
            balance = 500;
        }

        public double Deposit()
        {
            double NewBalance;
            double deposit;
            Console.WriteLine("please enter amount to deposit : ");
            deposit = double.Parse(Console.ReadLine());
            NewBalance = balance + deposit;
            return NewBalance;
        }
        public double Withdraw()
        {
            double NewBalance;
            double withdraw;
            Console.WriteLine("please enter amount to withdraw : ");
            withdraw = double.Parse(Console.ReadLine());
            NewBalance = balance - withdraw;

            return NewBalance;
        }

        public Account1(string accName,string acid,int balance)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }
        

    }
}
