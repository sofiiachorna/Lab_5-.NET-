using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public abstract class Money
    {
        public double amount { get; }
        public string symbol { get; }

        public Money(double amount, string symbol) 
        {
            this.amount = amount;
            this.symbol = symbol;
        }
    }
}
