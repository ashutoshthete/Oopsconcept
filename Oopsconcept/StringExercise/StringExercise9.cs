using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept.StringExercise
{
    class StringExercise9
    {
        static int noofchar = 300;
        public static bool areanagram(string s1,string s2)
        {
            int[] count1 = new int[noofchar];
            int[] count2 = new int[noofchar];

            for(int i = 0; i < s1.Length; i++)
            {
                count1[s1[i]]++;
            }
            for (int i = 0; i < s2.Length; i++)
            {
                count2[s2[i]]++;
            }


            if (s1.Length != s2.Length)
            {
                return false;
            }

            for(int i = 0; i < noofchar; i++)
            {
                if (count1[i] != count2[i]){
                    return false;
                }
            }

            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first string :");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter the second string :");
            string s2 = Console.ReadLine();

            if (areanagram(s1,s2))
            {
                Console.WriteLine("the string " + s1 + " and string " + s2 + " are anagram ");
            }
            else
            {
                Console.WriteLine("the string " + s1 + " and string " + s2 + " are not anagram ");
            }
        }
    }
}
