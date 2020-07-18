using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewPrograms
{
    class MultiThreading
    {
        List<int> ls = new List<int>
        {
            1,2,3,4,5
        };

        public void ParallelTest()
        {
            Parallel.For(0, 4, i =>
            {
                Console.WriteLine("hi there");
            });

            Parallel.For(0, 4,new ParallelOptions {MaxDegreeOfParallelism=2 }, i =>
            {
                Console.WriteLine("hi there");
            });
        }
        
        public void ParallelForEachTest()
        {
            Parallel.ForEach( ls, item =>
            {
                Console.WriteLine(item);
            });

            Parallel.ForEach(ls, new ParallelOptions(), item =>
            {
                Console.WriteLine(item);
            });
        }
    }
}
