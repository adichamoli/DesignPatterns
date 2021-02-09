using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternImpl
{
    class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();

            Console.WriteLine("QuickSorted list ");
        }
    }
}
