using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingLayer
{
    public interface IDataManager
    {
        Dictionary<string, Coin> getCoinData();
        Dictionary<string, Banknote> getBanknoteData();
    }
}
