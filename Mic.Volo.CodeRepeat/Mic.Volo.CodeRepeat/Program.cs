using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Mic.Volo.CodeRepeat
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 10, 20, 30, 40, 50 };
            var collection = new Collection<int>(list);
            list.Add(60);
            Console.WriteLine(String.Join(",", collection));
        }
    }
}
