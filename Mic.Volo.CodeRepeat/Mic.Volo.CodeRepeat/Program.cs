using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;

namespace Mic.Volo.CodeRepeat
{

   
    class Program
    {

        static double x = 5.0;
        static int y = 5;
        static DateTime time;
        static void Main(string[] args)
        {

            Console.WriteLine(x==y);
            Console.WriteLine(time==null);

            Console.ReadLine();
        }
        
    }
}
