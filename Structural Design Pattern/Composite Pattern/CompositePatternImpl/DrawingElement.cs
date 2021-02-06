using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePatternImpl
{
    abstract class DrawingElement
    {
        protected string _name;

        public DrawingElement(string name)
        {
            this._name = name;
        }

        public abstract void Add(DrawingElement d);
        public abstract void Remove(DrawingElement d);
        public abstract void Display(int indent);
    }
}
