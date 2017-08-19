using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinBaseHistoryLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesCounter = 0;
            DateTime startOfTime = new DateTime(1970, 1, 1);
            string CoinBaseHistoryCSV = "C:\\Users\\lahgs\\Downloads\\coinbaseUSD.csv\\.coinbaseUSD.csv";
            if (System.IO.File.Exists(CoinBaseHistoryCSV))
            {
                string line;

                // Read the file and display it line by line.
                System.IO.StreamReader file =
                   new System.IO.StreamReader(CoinBaseHistoryCSV);
                while ((line = file.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    //Console.WriteLine("Date: " + startOfTime.AddSeconds(Convert.ToInt64(values[0])));
                    linesCounter++;
                }

                file.Close();
            }
            //Console.WriteLine("Number of records found: " + linesCounter.ToString());
            //Console.ReadLine();
        }
    }
}
