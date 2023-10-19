using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingLayer.Concrete_handlers
{
    public class CoinHandler10UAH : BaseCoinHandler
    {
        public override bool EqualsMoney(Money money)
        {
            return money.amount.Equals(10) && money.symbol.Equals("UAH");
        }
    }
}
