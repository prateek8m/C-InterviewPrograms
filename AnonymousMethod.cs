using System;
using System.Collections.Generic;
using System.Text;

namespace EventHandlerDemo
{
    class AnonymousMethod
    {
        public delegate void sum(int val);

        sum s = delegate (int val) { Console.WriteLine("Inside Annoynomous method"); };


    }
}
