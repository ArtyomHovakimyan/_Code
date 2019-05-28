using System;
using System.Collections.Generic;
using System.Threading;

namespace Mic.Volo.CodeRepeat
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isComplete = false;

            var t = new Thread(() =>
            {
                int i = 0;
                while (!isComplete) i += 0;
            });

            t.Start();

            Thread.Sleep(500);
            isComplete = true;
            t.Join();
            Console.WriteLine("complete!");
        }
    }
}
