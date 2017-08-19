using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCTrader.Common;

namespace CCTrader.Exchanger
{
    public class TestExchanger : IExchanger, IDisposable
    {
        System.IO.StreamReader file;

        public TestExchanger()
        {
            string CoinBaseHistoryCSV = "C:\\Users\\lahgs\\Downloads\\coinbaseUSD.csv\\.coinbaseUSD.csv";
            if (System.IO.File.Exists(CoinBaseHistoryCSV))
            {
                // Read the file and display it line by line.
                file = new System.IO.StreamReader(CoinBaseHistoryCSV);
                /*while ((line = file.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    //Console.WriteLine("Date: " + startOfTime.AddSeconds(Convert.ToInt64(values[0])));
                    linesCounter++;
                }

                file.Close();*/
            }
        }
        public Exchange GetExchangeType()
        {
            return Exchange.Test;
        }
        public double GetExchangeRate(Currency from, Currency to)
        {
            string line;
            if ((line = file.ReadLine()) != null)
            {
                string[] values = line.Split(',');
                return Convert.ToDouble(values[1]);
            }
            throw new Exception("Unable to get bitcoin price");
        }

        public int ExecuteExchange(Currency from, Currency to, double amount)
        {
            return 0;
        }

        public double GetCurrentBalance(Currency c)
        {
            return 0;
        }

        bool disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    //dispose managed resources
                }
            }
            //dispose unmanaged resources
            file.Close();
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
