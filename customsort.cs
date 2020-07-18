using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInterviewPrograms
{
    class customsort 
    {
        class Mycollection:IComparable
        {
            public string FirstName { get; set; }
            public string secondName { get; set; }
            public int CompareTo(Object obj)
            {
                Mycollection customsort = obj as Mycollection;
                return this.FirstName.CompareTo(customsort.FirstName);
            }
        }

        public void check()
        {
            List<Mycollection> ls = new List<Mycollection>();
            ls.Add(new Mycollection() { FirstName = "prateeK", secondName = "kumar/" });
            ls.Add(new Mycollection() { FirstName = "aam", secondName = "and" });
            ls.Sort();

            foreach (var item in ls)
            {
                Console.WriteLine(item.FirstName,item.secondName);
            }
        }
        

       
    }
    
}
