using System;
using System.Collections.Concurrent;

namespace EventHandlerDemo
{
    class SystemConcurrentCollections
    {
        public void checkConcurrentCollections()
        {
            ConcurrentBag<int> vs = new ConcurrentBag<int>();
            vs.Add(2);
            vs.Add(3);

            ConcurrentDictionary<int, string> keyValuePairs = new ConcurrentDictionary<int, string>();
            keyValuePairs.AddOrUpdate(1,"sda", (key, oldValue) => oldValue + 1);

            //ConcurrentStack<int>
            //ConcurrentQueue<int>

            BlockingCollection<int> bc = new BlockingCollection<int>();
            bc.Add(1);
            bc.TryAdd(3);


        }
    }
}
