using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace ProcessingLayer
{ 
    public class BillHandler : IPaymentHandler
    {
        private readonly IMoneyData data;

        private IPaymentHandler next;
        public BillHandler(IMoneyData data)
        {
            this.data = data;
        }

        public void HandlePayment(ITerminal terminal, Money money)
        {
            var valid = new BillValidator(data.banknoteData);
            if(money is Banknote && valid.Validate(money).IsValid)
            {
                terminal.setMoney(money.amount);
                terminal.AddMoney(money);
            }
            else if (next != null)
            {
                next.HandlePayment(terminal, money);
            }

        }
        public void SetNext(IPaymentHandler handler)
        {
            next = handler;
        }
    }
}
