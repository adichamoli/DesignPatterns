using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePatternImpl
{
    class Customers : CustomersBase
    {
        public Customers(string group)
          : base(group)
        {
        }

        public override void ShowAll()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------");
            base.ShowAll();
            Console.WriteLine("------------------------");
        }
    }
}
