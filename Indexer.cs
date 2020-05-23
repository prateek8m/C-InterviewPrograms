using System;
using System.Collections.Generic;
using System.Text;

namespace EventHandlerDemo
{
    class Indexer
    {
        List<int> ls = new List<int>();

        public int this[int index]
        {
            get
            {
                return ls[index];
            }
            set
            {
                ls.Add(value);
            }
        }
    }
}
