using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInterviewPrograms
{
    class TwoStack
    {
        int top1;
        int top2;
        int size;
        int[] stack;

        public TwoStack(int _size)
        {
            size = _size;
            top1 = -1;
            top2 = size;
            stack = new int[size];

        }

        public void push1(int val)
        {
            if(top2-top1>1)
            {
                stack[++top1] = val;
            }
            else
            {
                throw new Exception("stack is full");
            }
        }
        public int pop1()
        {
            if(top1==-1)
            {
                throw new Exception("stack is empty");
            }
            else
            {
                return stack[top1--];
            }
        }

        public void push2(int val)
        {
            if (top2 - top1 > 1)
            {
                stack[--top2] = val;
            }
            else
            {
                throw new Exception("stack is full");
            }
        }
        public int pop2()
        {
            if (top1 == size)
            {
                throw new Exception("stack is empty");
            }
            else
            {
                return stack[top2++];
            }
        }
    }


}
