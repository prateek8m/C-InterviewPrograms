using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewPrograms
{
    class Partitioner1
    {
        public void partitionParallelThread()
        {
            var source = Enumerable.Range(0, 100).ToArray();

            var rangePartitioner = Partitioner.Create(0, source.Length);

            double[] results = new double[source.Length];

            Parallel.ForEach(rangePartitioner, (range,loopstate) =>
            {
                for(int i=range.Item1;i<range.Item2;i++)
                {
                    results[i] = source[i] * Math.PI;
                }

            });

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }
    }
}
