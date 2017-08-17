using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCTrader.Common;

namespace CCTrader.LocalWallet
{
    public class SqlWallet : ILocalWallet
    {
        public double GetLocalBalance(Exchange e, Currency c)
        {
            return 0;
        }
        public void SaveLocalBalance(Exchange e, Currency c, double newBalance)
        {
        }
        public void LogExchange(Exchange e, Currency from, Currency to, double rate)
        {
        }
    }
}
