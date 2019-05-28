using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Mic.Volo.CodeRepeat
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> nullableVariable = 0;
            int intVariable = 1;
            Console.WriteLine(nullableVariable.GetType() == intVariable.GetType());
        }
    }
}
