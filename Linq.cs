using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpInterviewPrograms
{
    //static class Extension
    //{
    //    public static int Count(this string s)
    //    {
    //        int n = s.Count();
    //        return n;
    //    }
    //}
    class Linq
    {
        public void check()
        {
            string s = "rambaghpurnea";
            int res=s.Where(x => x.Equals('a') || x.Equals('e') || x.Equals('i') || x.Equals('o') || x.Equals('u')).Count();
            Console.WriteLine(res);
            s.Count();
            
        }
        public void check2() //query syntax
        {
            SortedList<string, int> sortedList = new SortedList<string, int>();
            sortedList.Add("one", 1);
            sortedList.Add("two", 2);
            sortedList.Add("three", 3);
            sortedList.Add("four", 4);
            sortedList.Add("five", 5);

            var query = from kvp in sortedList
                        where kvp.Key == "two"
                        select kvp;

            var result = query.FirstOrDefault();

            Console.WriteLine("key: {0}, value: {1}", result.Key, result.Value);
        }

    }
}
