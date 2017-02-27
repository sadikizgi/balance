using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP10022017
{
    class Account
    {
      private decimal balance;

        public decimal Balance
        {
            get
            {
                return balance;
            }

            set
            {
                if (value >= 0)
                    balance = value;
               
            }
        }
        public void Credit(decimal amount)
        {
            balance = balance + amount;
        }
        public void WithDraw(decimal amount)
        {
            if (amount > balance)
                Console.WriteLine("There is not enough money!");
            else
                balance = balance - amount;
        }
    }
}
