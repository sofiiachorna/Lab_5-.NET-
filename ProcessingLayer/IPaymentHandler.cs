using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingLayer
{
    public interface IPaymentHandler
    {
        void SetNext(IPaymentHandler handler);
        void HandlePayment(ITerminal terminal, Money money);
    }
}
