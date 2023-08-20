using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSample
{
    class PrintClass
    {
        public async Task Print(string message)
        {
            await Task.Delay(millisecondsDelay: 1000);
            Console.WriteLine(message);
        }
        public static void ParallelPrint(string message)
        {
            Console.WriteLine(message);
        }

    }
}
