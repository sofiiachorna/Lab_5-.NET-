using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Coin : Money
    {
        public Coin(double amount, string symbol) : base(amount, symbol) { }

    }
}
