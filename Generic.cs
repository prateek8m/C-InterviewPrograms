using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EventHandlerDemo
{
    class NonGenericList :IComparable,IEnumerable
    {
        int size = 10;
        int curr_index = 0;
        object [] arr;
        public NonGenericList()
        {
            arr = new object[size];

        }

        public object this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
        public void insert(object val)
        {
            if (curr_index == size - 1)
            {
                size = 2 * size;
                object[] list = new object[size];
                for (int i = 0; i < curr_index; i++)
                {
                    list[i] = arr[i];
                }
                arr = list;
            }
            arr[curr_index] = val;
            curr_index++;
        }

        public object getvalue(int index)
        {
            if (index > curr_index || index < 0)
            {
                throw new Exception("Out of bound Exception");
            }
            else
            {
                return arr[index];
            }
        }

        //public int CompareTo(object obj)
        //{
        //    NonGenericList nonGenericList = obj as NonGenericList;

        //    int m = nonGenericList.size;
        //    int i = 0;
        //    while(i<size && i<m)
        //    {
        //        if(nonGenericList[i]<arr[i])
        //        {

        //        }
        //    }
        //}

        IEnumerator  GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public int CompareTo(object obj)
        {
            NonGenericList nonGenericList = obj as NonGenericList;
            return nonGenericList.CompareTo(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    class MyGenericList<T>
    {
        int size = 10;
        int curr_index = 0;
        T[] arr;
        public MyGenericList()
        {
            arr = new T[size];

        }
        public void insert(T val)
        {
            if(curr_index==size-1)
            {
                size = 2 * size;
                T[] list = new T[size];
                for(int i=0;i<curr_index;i++)
                {
                    list[i] = arr[i];
                }
                arr = list;
            }
            arr[curr_index] = val;
            curr_index++;
        }

        public T getvalue(int index)
        {
            if(index>curr_index || index<0)
            {
                throw new Exception("Out of bound Exception");
            }
            else
            {
                return arr[index];
            }
        }


    }
    class Generic
    {   
        public void check()
        {
            MyGenericList<int> myGenericList = new MyGenericList<int>();
            myGenericList.insert(3);
            myGenericList.insert(4);
            Console.WriteLine(myGenericList.getvalue(1));

            NonGenericList nonGenericList = new NonGenericList();
            nonGenericList.insert(3);
            nonGenericList.insert("sd");
            Console.WriteLine(nonGenericList.getvalue(1));
        }
        
        
    }

}
