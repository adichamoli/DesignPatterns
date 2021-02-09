using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternImpl
{
    class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("MergeSorted list ");
        }
    }
}
