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
            ILocalWallet wallet = new TestWallet();
            IManager cManager = new ConservativeManager(wallet, exchanger);
            for (int i = 0; i < 1000; i++)
            {
                cManager.Execute();
            }
        }
    }
}
