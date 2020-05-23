using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventHandlerDemo
{
    class AsynAwait
    {

        public async Task check()
        {
            Console.WriteLine("before Await");
            await asynmethod();

            Console.WriteLine("After await");
        }

        public async Task<string> asynmethod()
        {
            Thread.Sleep(50000);
            return "Ram";
        }
    }
}
