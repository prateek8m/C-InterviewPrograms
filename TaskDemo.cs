using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpInterviewPrograms
{
    class TaskDemo
    {
        //The await operator suspends the execution of the current method, GetURLContents, until the awaited task is complete.In the meantime, control returns to the caller of the current method.
        public void Mutithreads()
        {
            Thread t = new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    if(i%2!=0)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("thread1");
            });

            Thread t2 = new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    if(i%2==0)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("thread2");
            });

            t.Start();
            
            t2.Start();
            t.Join();
            t2.Join();

        }


        public async void CreateTask()
        {
            List<Task<string>> ls = new List<Task<string>>();
            ls.Add(Task<string>.Run(() =>
            {
                Thread.Sleep(5000);
                return "thread1";
            }));

            ls.Add(Task<string>.Run(() =>
            {
                Thread.Sleep(2000);
                return "thread2";
            }));

            ls.Add(Task<string>.Run(() =>
            {
                Thread.Sleep(3000);
                return "thread3";
            }));

            ls.Add(Task<string>.Run(() =>
            {
                Thread.Sleep(4000);
                return "thread4";
            }));

            ls.Add(Task<string>.Run(() =>
            {
                Thread.Sleep(3500);
                return "thread5";
            }));

            //var res = await Task.WhenAll(ls);

            //for (int i = 0; i < ls.Count; i++)
            //{
            //    Console.WriteLine(res[i]);
            //}

            while (ls.Count>0)
            {
                Task<string> completedTask = await Task.WhenAny(ls);
                Console.WriteLine(completedTask.Result);
                ls.Remove(completedTask);
            }

        }
    }
}
