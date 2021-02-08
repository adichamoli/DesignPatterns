using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPatternImpl
{
    class Item
    {
        private string _name;

        public Item(string name)
        {
            this._name = name;
        }

        public string Name
        {
            get { return _name; }
        }
    }
}
