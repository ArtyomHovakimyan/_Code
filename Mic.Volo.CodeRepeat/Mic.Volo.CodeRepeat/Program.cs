using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Mic.Volo.CodeRepeat
{
    class Program
    {
        static void Main(string[] args)
        {
            char x = 'X';
            int i = 0;
            Console.WriteLine(true ? x : 0);
            Console.WriteLine(false ? i : x);
        }
    }
}
