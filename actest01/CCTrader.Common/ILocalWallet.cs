using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCTrader.Common
{
    public interface ILocalWallet
    {
        double GetLocalBalance(Exchange e, Currency c);
        void SaveLocalBalance(Exchange e, Currency c, double newBalance);
        void LogExchange(Exchange e, Currency from, Currency to, double rate);
    }
}
