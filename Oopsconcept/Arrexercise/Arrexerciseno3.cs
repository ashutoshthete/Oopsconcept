using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept.Arrexercise
{
    class Arrexerciseno3
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 44, 55, 85, 95, 74, 64, 31, 45, 85, 31, 45, 62, 78 ,64};
            int f = 64;
            int len = arr.Length;
            int i = 0;
            while (i < len)
            {
                if (arr[i] == f)
                {
                    Console.WriteLine(f+" found at index : "+i);
                    
                
               
                    
                }
                i = i + 1;
            }
        }
    }
}
