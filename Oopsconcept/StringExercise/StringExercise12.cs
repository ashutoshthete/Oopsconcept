using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept.StringExercise
{
    class StringExercise12
    {
        static string revwords(string str)
        {
            string revstr = "";
            for(int i = str.Length - 1; i >= 0; i--)
            {
                revstr = revstr + str[i];
            }
            return revstr;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            string[] arr = str.Split();
            string resrev = "";
            Console.WriteLine("\n");
            foreach(string revstr in arr)
            {
                resrev = revwords(revstr);
                Console.WriteLine(resrev+" ");
            }
            
           
            
            
           
        }
    }
}
