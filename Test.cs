using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInterviewPrograms
{
    class Test
    {
        int comp(int a, int b)
        {
            return a.CompareTo(b);
        }
        public void method()
        {
            List<int> ls = new List<int>
            {
                2,
                4
            };
            // ls.Sort((int a,int b)=>{ return b.CompareTo(a); });
            ls.Sort(comp);
            for (int i = 0; i < ls.Count; i++)
            {
                Console.WriteLine(ls[i]);
            }

            int[] arr = new int[] { 1, 27, 3, 4, 1, 2 };
            Array.Sort(arr, (a, b) => { return a.CompareTo(b); });



        }

        public void set()
        {
            HashSet<int> hs = new HashSet<int>();
            hs.Add(1);
            hs.Add(1);
            Console.WriteLine(hs.Count);

            
        }
    }

 
 // C# program to demonstrate the concept of 
// List<T>.Sort(IComparer <T>) method 

    class GFG : IComparer<string>
    {
        public int Compare(string x, string y)
        {

            if (x == null || y == null)
            {
                return 0;
            }

            // "CompareTo()" method 
            return x.CompareTo(y);

        }
    }

    public class geek
    {

        // Main Method 
        public static void SortIcomparer()
        {
            List<string> list1 = new List<string>();

            // list elements 
            list1.Add("A");
            list1.Add("I");
            list1.Add("G");
            list1.Add("B");
            list1.Add("E");
            list1.Add("H");
            list1.Add("F");
            list1.Add("C");
            list1.Add("J");

            Console.WriteLine("Original List");

            // Display Original List 
            Display(list1);

            // "gg" is the object 
            GFG gg = new GFG();

            Console.WriteLine("\nSort with a comparer:");

            // sort the list with a 
            // specified comparer "gg" 
            list1.Sort(gg);

            // Display sorted List 
            Display(list1);

            Console.WriteLine("\nBinarySearch and Insert D");

            // Binary Search for "D" 
            // using List.BinarySearch(T) method 
            int index = list1.BinarySearch("D");

            if (index < 0)
            {

                // range++; 
                list1.Insert(~index, "D");

            }

            // Display the List after 
            // inserting "D" 
            Display(list1);

        }

        // Display function 
        public static void Display(List<string> list)
        {
            foreach (string g in list)
            {
                Console.WriteLine(g);
            }
        }
    }

}

