using System;

namespace Mic.Volo.CodeRepeat
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 100;
            dynamic d = b;
            Console.WriteLine(d.GetType());
            d += 100;
            Console.WriteLine(d.GetType());
        }
    }
}
