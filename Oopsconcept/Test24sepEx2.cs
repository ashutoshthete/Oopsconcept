using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Test24sepEx2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string :");
            string str = Console.ReadLine();
            string[] arr = str.Split();
            foreach(string vstr in arr)
            {
                Console.WriteLine(vstr);
            }

        }  
    }
}
