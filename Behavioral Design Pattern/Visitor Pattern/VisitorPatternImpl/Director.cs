using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPatternImpl
{
    class Director : Employee
    {
        public Director()
          : base("Elly", 35000.0, 16)
        {
        }
    }
}
