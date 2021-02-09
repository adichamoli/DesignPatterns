using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternImpl
{
    abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}
