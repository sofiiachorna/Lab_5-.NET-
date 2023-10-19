using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingLayer
{
    public class DataManager : IDataManager
    {
        private readonly IMoneyData data;
        public DataManager(IMoneyData data)
        { this.data = data; }
        public Dictionary<string, Coin> getCoinData() => data.coinData;
        public Dictionary<string, Banknote> getBanknoteData() => data.banknoteData;
    }
}
