using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask6
{
    class Account
    {
        private String accName;
        private String acid;
        private int balance;

        public Account()
        {
            Console.WriteLine("account default");
        }
        public Account(string accName,string acid,int balance)
        {
            Console.WriteLine("account default");
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }

    }
}
