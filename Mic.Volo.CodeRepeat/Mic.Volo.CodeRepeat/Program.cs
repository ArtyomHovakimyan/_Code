using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Mic.Volo.CodeRepeat
{
    class Program
    {
        static void Main(string[] args)
        {
            double dVal = 100.1;
            Console.WriteLine((int)dVal);

            object objVal = dVal;
            Console.WriteLine((int)objVal);
        }
    }
}
