using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcessingLayer;

namespace PresentationLayer
{
    public class Runner : IRunner
    {
        private readonly IDataManager _dataManager;
        private readonly ITerminal _terminal;

        public Runner(IDataManager dataManager, ITerminal terminal)
        {
            this._dataManager = dataManager;
            this._terminal = terminal;
        }

        public void Run()
        {
            var banknoteData = _dataManager.getBanknoteData();
            var coinData = _dataManager.getCoinData();
            string a = "";
            while(a != "no")
            {
                Console.WriteLine("Enter money you want to add:");
                string ans = Console.ReadLine();
                string[] options = ans.Split(" ");
                if(options.Length == 0 || options.Length > 2)
                {
                    Console.WriteLine("You can only add 1 item");
                }
                else if (options[0].Equals("b") && banknoteData.ContainsKey(options[1])) 
                { 
                   _terminal.CollectPayment(banknoteData[options[1]]);
                }
                else if (options[0].Equals("c") && coinData.ContainsKey(options[1]))
                {
                    _terminal.CollectPayment(coinData[options[1]]);
                }
                else
                {
                    Console.WriteLine("Something wrong with the input. try again");
                }
                Console.WriteLine("Do you want to continue?");
                a = Console.ReadLine();

                
            }
            Console.WriteLine("Total money inserted:");
            Console.WriteLine(_terminal.getMoney());

            Console.WriteLine("Amount of banknotes and coins inserted:");
            Console.WriteLine(_terminal.GetAllMoney());
        }
    }
}
