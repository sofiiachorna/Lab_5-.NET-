using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingLayer
{
    public abstract class BaseCoinHandler : IPaymentHandler
    {
        private IPaymentHandler next;
        public void SetNext(IPaymentHandler handler)
        {
            next = handler;
        }
        public void HandlePayment(ITerminal terminal, Money money)
        {
            if (money is Coin && EqualsMoney(money))
            {
                terminal.setMoney(money.amount);
                terminal.AddMoney(money);
            }
            else if (next != null)
            {
                next.HandlePayment(terminal, money);
            }
        }

        public virtual bool EqualsMoney(Money money)
        {
            return false;
        }
    }
}
