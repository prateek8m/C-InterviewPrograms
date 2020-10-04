using System;
using System.Collections.Generic;
using System.Text;

namespace EventHandlerDemo
{
    class Overriding
    {
        public void check()
        {
            A a = new A();
            B b = new B();
            C c = new C();

            //a.Test(); // output --> "A::Test()"
            //b.Test(); // output --> "B::Test()"
            //c.Test(); // output --> "C::Test()"

            a = new B();
            a.Test(); // output --> "A::Test()"

            b = new C();
            b.Test(); // output --> "B::Test()"
        }
    }
    class A
    {
        public void Test() { Console.WriteLine("A::Test()"); }
    }

    class B : A
    {
        public new void Test() { Console.WriteLine("B::Test()"); }
    }

    class C : B
    {
        public new void Test() { Console.WriteLine("C::Test()"); }
    }

    abstract class E
    {
        //public void Method1();

    }

}
