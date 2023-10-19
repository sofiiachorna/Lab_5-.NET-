using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IMoneyData
    {
        Dictionary<string, Coin> coinData { get;}
        Dictionary<string, Banknote> banknoteData { get;}
    }
}
