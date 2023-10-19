using DataLayer;
using ProcessingLayer.Concrete_handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingLayer
{
    public class PaymentTerminal : ITerminal
    {

        private IPaymentHandler chain;
        private readonly IMoneyData data;
        private double moneyAmount;
        private List<Money> allMoney;
        public PaymentTerminal(IMoneyData data)
        {
            this.data = data;
            buildChain();
            moneyAmount = 0.0;
            allMoney = new List<Money>();
        }
        private void buildChain()
        {
            chain = new BillHandler(data);
            IPaymentHandler coin10uah = new CoinHandler10UAH();
            IPaymentHandler coin5uah = new CoinHandler5UAH();
            IPaymentHandler coin2uah = new CoinHandler2UAH();
            IPaymentHandler coin1uah = new CoinHandler1UAH();
            IPaymentHandler coin50c = new CoinHandler50Cent();

            chain.SetNext(coin10uah);
            coin10uah.SetNext(coin5uah);
            coin5uah.SetNext(coin2uah);
            coin2uah.SetNext(coin1uah);
            coin1uah.SetNext(coin50c);
            coin50c.SetNext(null);
        }

        public void CollectPayment(Money money)
        {
            chain.HandlePayment(this, money);
        }

        public double getMoney() => moneyAmount;
        public void setMoney(double amount)
        {
            moneyAmount += amount;
        }

        public void AddMoney(Money money)
        {
            allMoney.Add(money);
        }

        public string GetAllMoney()
        {
            var history = allMoney
            .GroupBy(a => (a.amount, a.symbol, a.GetType().Name))
            .Select(b =>
                $"{b.Key.Name} {b.Key.amount}" +
                $"{b.Key.symbol} : " +
                $"{b.Count()}");

            return string.Join("\n", history);
        }
    }
}
