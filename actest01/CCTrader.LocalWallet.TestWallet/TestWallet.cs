using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCTrader.Common;

namespace CCTrader.LocalWallet
{
    public class TestWallet : ILocalWallet
    {
        static double btcBalance = 0;
        static double mxnBalance = 10000;
        public double GetLocalBalance(Exchange e, Currency c)
        {
            switch (c)
            {
                case Currency.MXN:
                    return mxnBalance;
                    break;
                case Currency.BTC:
                    return btcBalance;
                    break;
                default:
                    throw new Exception("Unknown currency: " + c == null ? "null":c.GetType().ToString());
            }
        }

        public void SaveLocalBalance(Exchange e, Currency c, double newBalance)
        {
            switch (c)
            {
                case Currency.MXN:
                    mxnBalance = newBalance;
                    break;
                case Currency.BTC:
                    btcBalance = newBalance;
                    break;
                default:
                    throw new Exception("Unknown currency: " + c == null ? "null" : c.GetType().ToString());
            }
        }

        public void LogExchange(Exchange e, Currency from, Currency to, double rate)
        {
        }
    }
}
