using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPatternImpl
{
    interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}
