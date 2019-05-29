using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;

namespace Mic.Volo.CodeRepeat
{
    class Program
    {
        static int counter = 0;
        static object locker = new object();
        static void Main(string[] args)
        {

            new Thread(PrintStar).Start();
            new Thread(PrintHashTag).Start();

            Console.ReadLine();
        }
        static void PrintStar()
        {
            lock(locker)
            {
                for (counter = 0; counter < 5; counter++)
                {
                    Console.WriteLine("*"+"\t");
                }
            }
        }
        public static void PrintHashTag()
        {
            lock (locker)
            {
                for (counter = 0; counter < 5; counter++)
                {
                    Console.WriteLine("#" + "\t");
                }
            }
        }
    }
}
