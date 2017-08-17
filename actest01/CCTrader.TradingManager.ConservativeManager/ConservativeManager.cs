using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCTrader.Common;

namespace CCTrader.TradingManager
{
    public class ConservativeManager : IManager
    {
        ILocalWallet wallet;
        IExchanger exchange;

        public ConservativeManager(ILocalWallet w, IExchanger e)
        {
            wallet = w;
            exchange = e;
        }

        public Manager GetManagerType()
        {
            return Manager.Conservative;
        }

        public void Execute()
        {
        }
    }
}
