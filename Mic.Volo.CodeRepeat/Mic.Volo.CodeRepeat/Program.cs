using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;

namespace Mic.Volo.CodeRepeat
{
    class GameScore
    {
        string user;
        int age;
        public GameScore()
        {
            user = "Smith";
            age = 28;
            Console.WriteLine("Previous User {0} and he was {1} year old",user,age);
        }
        public GameScore(string name,int age1)
        {
            user = name;
            age = age1;
            Console.WriteLine("Current User {0} and he is {1} year old",user,age);
        }
    }
    class Program
    {
       
        static IEnumerable<int> YieldReturn()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }
        static string _name;
        static string Name
        {
            get
            {
                return _name ?? "Default";
            }
            set
            {
                _name = value;
            }
        }
        static void Main(string[] args)
        {
            Double i = Double.NaN;
            while (i == i)
            {
                Console.WriteLine("Hello");
            }

            Console.ReadLine();
        }
        
    }
}
