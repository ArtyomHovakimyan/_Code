using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;

namespace Mic.Volo.CodeRepeat
{

   
    class Program
    {

        static String location;
        static DateTime time;
        static void Main(string[] args)
        {

            Console.WriteLine(location==null?"location is null":location);
            Console.WriteLine(time==null?"time is null":time.ToString());

            Console.ReadLine();
        }
        
    }
}
