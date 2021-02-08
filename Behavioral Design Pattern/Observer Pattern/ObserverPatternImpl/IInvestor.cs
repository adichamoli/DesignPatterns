using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternImpl
{
    interface IInvestor
    {
        void Update(Stock stock);
    }
}
