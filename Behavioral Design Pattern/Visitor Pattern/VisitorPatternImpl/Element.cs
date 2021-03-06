﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPatternImpl
{
    abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}
