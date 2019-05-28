using System;
using System.Collections.Generic;

namespace Mic.Volo.CodeRepeat
{
    class Program
    {
        static void Main(string[] args)
        {
            var actions = new List<Action>();
            for (int i = 0; i < 4; i++)
            {
                actions.Add(() => Console.WriteLine(i));

            }
            foreach (var action in actions)
            {
                action();
            }
        }
    }
}
