using System;
using System.Collections.Generic;
using System.Text;

namespace EventHandlerDemo
{
    class NestedClass
    {
        private string st = "Ram";
        public void check()
        {
            Console.WriteLine("shyam");
        }
        public class Nested
        {

            private string s = "asd";
            public void check()
            {
                NestedClass nested = new NestedClass();
                Console.WriteLine(nested.st);

            }

        }
    }
}
