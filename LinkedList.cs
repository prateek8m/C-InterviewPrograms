using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInterviewPrograms
{
    class LinkedList
    {

        int val;
        LinkedList next;
        public LinkedList(int data)
        {
            val = data;
            next = null;
        }

        public LinkedList InsertNewNode(LinkedList root, int data)
        {
            root.next = new LinkedList(data);
            return root.next;
        }

        public  void Print(LinkedList root)
        {
            while(root!=null)
            {
                Console.WriteLine(root.val);
                root = root.next;
            }
        }

        public LinkedList Reverse(LinkedList root)
        {
            LinkedList next, prev, curr;
            prev = null;
            curr = root;
            while(curr!=null)
            {
                next = curr.next;
                curr.next = prev;

                prev = curr;
                curr = next;
            }
            return prev;
        }

    }
}
