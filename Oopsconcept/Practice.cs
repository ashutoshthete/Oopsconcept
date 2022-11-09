using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Practice
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
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            string[] arr = str.Split();
            string resultrev = "";
            foreach(string revstr in arr)
            {
                resultrev = revwords(revstr);
                Console.WriteLine(resultrev+" ");
            }
            

        }
    }
}
