using System;
using System.Collections.Generic;

namespace EventHandlerDemo
{
    class SystemGenericCollections
    {
        public void checkGenericCollections()
        {
            List<int> ls = new List<int>();
            ls.Add(2);
            ls.Add(3);
            ls.AddRange(new List<int> { 3, 4, 5 });
            Console.WriteLine( ls.Count);
            Console.WriteLine(  ls[2]);

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "prateek");
            dict.Add(2, "kumar");
            dict.ContainsKey(1);
            dict.TryGetValue(1, out string s);

            //Stack
            //Queue
            //SortedList

            HashSet<string> hs = new HashSet<string>();
            hs.Add("asda");
            hs.Add("asda");
            Console.WriteLine(hs.Count);


        }
    }
}
