using System;
using DataLayer;
using ProcessingLayer;
using PresentationLayer;
using Microsoft.Extensions.DependencyInjection;

 namespace Lab_5
{
    public class Program
    {
        static void Main(string[] args) 
        {
            var collection = new ServiceCollection();

            collection.AddSingleton<IMoneyData, MoneyData>();
            collection.AddSingleton<IDataManager, DataManager>();
            collection.AddTransient<ITerminal, PaymentTerminal>();
            collection.AddTransient<IRunner, Runner>();

            collection.BuildServiceProvider().GetService<IRunner>().Run();
        }
    }
   
}
