using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharpInterviewPrograms
{
    class SemaphoreCheck
    {
       static Semaphore semaphore = new Semaphore(2, 3);  // 3 resource but only 2 can concurrently use, initialcount always<= maxcount
                                                          //3 resouce max, with 2 can enter at initial time

      /* A semaphore is a signalling mechanism and a thread that is waiting on a semaphore can be signaled by another thread.
       * This is different than a mutex as the mutex can be signaled only by the thread that called the wait function.*/
       public void check()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(dowork);
                thread.Start();
            }

        }
        

        public void dowork()
        {

            semaphore.WaitOne();
            //critical section

            Console.WriteLine("Inside critical section");
            Thread.Sleep(1000);

            semaphore.Release();
        }




    }
}
