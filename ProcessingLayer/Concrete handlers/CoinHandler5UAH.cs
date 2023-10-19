using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingLayer.Concrete_handlers
{
    public class CoinHandler5UAH : BaseCoinHandler
    {
        public override bool EqualsMoney(Money money)
        {
            return money.amount.Equals(5) && money.symbol.Equals("UAH");
        }
    }
}
