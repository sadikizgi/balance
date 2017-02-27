using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP10022017
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account();
            Account account2 = new Account();
            account1.Balance = -5;
            account2.Balance = 10.0M;
            Console.WriteLine("Balance1: {0}",account1.Balance);
            Console.WriteLine("Balance2: {0}", account2.Balance);
            account1.Credit(15);
            Console.WriteLine("Balance1: {0}", account1.Balance);
            Console.WriteLine("Balance2: {0}", account2.Balance);
            account1.WithDraw(5);
            Console.WriteLine("Balance1: {0}", account1.Balance);
            
        }
    }
}
