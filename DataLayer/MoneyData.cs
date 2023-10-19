using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class MoneyData : IMoneyData
    {
        public Dictionary<string, Coin> coinData => new Dictionary<string, Coin>
        {
            {"50C", new Coin(0.5, "C") },
            {"1UAH", new Coin(1, "UAH") },
            {"2UAH", new Coin(2, "UAH") },
            {"5UAH", new Coin(5, "UAH") },
            {"10UAH", new Coin(10, "UAH") }
        };

        public Dictionary<string, Banknote> banknoteData => new Dictionary<string, Banknote>
        {
            {"5UAH", new Banknote(5, "UAH") },
            {"10UAH", new Banknote(10, "UAH") },
            {"20UAH", new Banknote(20, "UAH") },
            {"50UAH", new Banknote(50, "UAH") },
            {"100UAH", new Banknote(100, "UAH") },
            {"200UAH", new Banknote(200, "UAH") },
            {"500UAH", new Banknote(500, "UAH") },
            {"1000UAH", new Banknote(1000, "UAH") }
        };

    }
}
