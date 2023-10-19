using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace ProcessingLayer
{
    public interface ITerminal
    {
        void CollectPayment(Money money);
        double getMoney();
        void setMoney(double amount);
        string GetAllMoney();
        void AddMoney(Money money);
    }
}
