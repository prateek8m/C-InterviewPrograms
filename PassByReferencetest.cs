using System;
using System.Collections.Generic;
using System.Text;

namespace EventHandlerDemo
{
    class PassByReferencetest
    {
        public int roll;
        public string name;
        public void update( PassByReferencetest pass)
        {
            pass = new PassByReferencetest();
            pass.name = "prateek";
           // pass = null;
        }

        public void updatelist( List<int> pass)
        {
            //pass.name = "prateek";
           // pass = null;
        }

        public void updatevaluetype(ref int b)
        {
            b = 20;

        }

    }
    class check
    {
        public void Check()
        {
            PassByReferencetest pass = new PassByReferencetest();
            pass.name = "rahul";
            pass.update( pass);

            //List<int> ls = new List<int>();
            //ls.Add(1);
            //ls.Add(2);
            //ls.Add(3);
            //pass.updatelist( ls);
            //foreach (var item in ls)
            //{
            //    Console.WriteLine(item);
            //}
           

            //int a = 10;
            //pass.updatevaluetype(ref a);
            Console.WriteLine(pass.name);

        }


    }
}
