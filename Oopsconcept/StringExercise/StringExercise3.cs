using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept.StringExercise
{
    class StringExercise3
    {
 
        static void Main(string[] args)
        {
            string s1 = "sdfgvhfgtgegh";
            for(int i = 0; i < s1.Length; i++)
            {
                Console.WriteLine(s1[i]);
            }
            Console.WriteLine(s1.IndexOf('g'));

        }
    }
}
