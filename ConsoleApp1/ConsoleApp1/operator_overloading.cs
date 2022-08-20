using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Money
    {
        private decimal amount; 
        public decimal Amount 
        { 
            get { return amount; } 
        }
        public Money(decimal value)
        {
            this.amount = value;
        }

        public static Money operator+(Money m1, Money m2) 
        {
            return new Money(m1.Amount + m2.Amount);
        }
    }
}
