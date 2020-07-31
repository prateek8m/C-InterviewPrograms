using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInterviewPrograms
{
    class VariablesTypes
    {
        //static variable can't be re declared;
        // scope is class
        //can't be inside method
       // static int d;
        public  void Test()
        {
            int d;
            d = 3;
            d = 5;
            Console.WriteLine(d);

            List<int> ls = new List<int>();
            ls.Sort();

        }
    }
}
