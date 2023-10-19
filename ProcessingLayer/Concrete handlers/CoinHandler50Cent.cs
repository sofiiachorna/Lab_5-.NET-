using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingLayer.Concrete_handlers
{
    public class CoinHandler50Cent : BaseCoinHandler
    {
        public override bool EqualsMoney(Money money)
        {
            return money.amount.Equals(0.5) && money.symbol.Equals("C");
        }
    }
}
