using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCTrader.Common;
using CCTrader.Exchanger;
using CCTrader.LocalWallet;
using CCTrader.TradingManager;

namespace actest01
{
    class Program
    {
        static void Main(string[] args)
        {
            IExchanger exchanger = new TestExchanger();
            /*
            //Testing TestExchanger
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine("Value of bitcoin is: " + exchanger.GetExchangeRate(Currency.USD, Currency.BTC));
            }*/
            Console.ReadKey();
            /*ILocalWallet wallet = new TestWallet();
            IManager cManager = new ConservativeManager(wallet, exchanger);
            for (int i = 0; i < 1000; i++)
            {
                cManager.Execute();
            }*/
        }
    }
}
