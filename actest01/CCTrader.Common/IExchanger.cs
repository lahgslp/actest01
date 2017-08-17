using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCTrader.Common
{
    public interface IExchanger
    {
        Exchange GetExchangeType();
        double GetExchangeRate(Currency from, Currency to);
        int ExecuteExchange(Currency from, Currency to, double amount);
        double GetCurrentBalance(Currency c);
    }
}
