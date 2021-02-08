using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternImpl
{
    class IBM : Stock
    {
        public IBM(string symbol, double price)
          : base(symbol, price)
        {
        }
    }
}
