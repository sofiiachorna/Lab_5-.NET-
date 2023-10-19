using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Banknote : Money
    {
        public Banknote(double amount, string symbol) : base(amount, symbol) { }
    }
}
