using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCTrader.Common;

namespace CCTrader.Exchanger
{
    public class TestExchanger : IExchanger
    {
        public Exchange GetExchangeType()
        {
            return Exchange.Test;
        }
        public double GetExchangeRate(Currency from, Currency to)
        {
            return 0;
        }

        public int ExecuteExchange(Currency from, Currency to, double amount)
        {
            return 0;
        }

        public double GetCurrentBalance(Currency c)
        {
            return 0;
        }
    }
}
