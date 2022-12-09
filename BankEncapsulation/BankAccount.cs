using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance;

        public void Deposit(double amount)
        {
            Console.WriteLine($"Adding a deposit of {amount, 0:c} to your Account!");
            _balance = amount;
        }

        public double GetBalance()
        { 
        return _balance;
        }
    }
}
