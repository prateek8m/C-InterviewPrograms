using System;
using System.Collections;

namespace EventHandlerDemo
{
    class SystemCollections
    {
        public void checkCollections()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(12);
            arrayList.Add("Asd");
            Console.WriteLine(arrayList[1]);

            Hashtable hashtable = new Hashtable();
            hashtable.Add("a", 1);
            hashtable.Add(1, "a");
            hashtable.Contains("a");
            int h=hashtable.Count;
            hashtable.Clear();
            hashtable.ContainsValue(1);



            Console.WriteLine(hashtable[1]);

            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(3);
            queue.Dequeue();
            queue.Peek();
            int o=queue.Count;
            //var it=queue.GetEnumerator();
            


            Stack stack = new Stack();
            stack.Push(2);
            stack.Peek();
            stack.Pop();

            SortedList sortedList = new SortedList();
            sortedList.Add(1, "ew");
            sortedList.Add(4, "ad");
            Console.WriteLine(  sortedList.GetByIndex(1));

            

        }


    }
}
