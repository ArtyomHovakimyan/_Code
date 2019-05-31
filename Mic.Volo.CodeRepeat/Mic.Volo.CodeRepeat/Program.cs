using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;

namespace Mic.Volo.CodeRepeat
{

   
    class Program
    {
       static long Total(int[] arr)
        {
            long result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i]%2==0)
                {
                    result += arr[i];
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] a = new int[]
            {
                1,3,5,7,10,2,4,6,8
            };
            Console.WriteLine(Total(a));
           

            Console.ReadLine();
        }
        
    }
}
