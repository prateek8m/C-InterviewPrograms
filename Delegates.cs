using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpInterviewPrograms
{
    class Delegates
    {

        public delegate int calculation(int a, int b);

        public int sum(int a, int b)
        {
            //calculation calculation = delegate (int c, int d) { return c + d; };
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public void Action(int a, int b)
        {
            Console.WriteLine(a);
        }
        public void check()
        {
            calculation calculation = sum;
            calculation calculation2 = Subtract;
            Console.WriteLine(calculation(2,3));
            Console.WriteLine(calculation2(3,4));

            Func<int, int, int> add = sum;
            add(1, 2);

            Action<int, int> actio = Action;
            actio(4, 5);
        }

        bool Isbignumber(int a)
        {
            return a > 488;
        }

        //public void check2()
        //{
        //    int[] numbers = { 1, 5, 1000, 10 };
        //    var bigNumbers = numbers.Where(Isbignumber).or;
        //}


    }
}
