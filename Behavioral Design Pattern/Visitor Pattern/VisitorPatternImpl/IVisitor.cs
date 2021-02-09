using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPatternImpl
{
    interface IVisitor
    {
        void Visit(Element element);
    }
}
