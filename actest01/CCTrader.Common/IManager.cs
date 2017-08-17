using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCTrader.Common
{
    public interface IManager
    {
        Manager GetManagerType();
        void Execute();
    }
}
