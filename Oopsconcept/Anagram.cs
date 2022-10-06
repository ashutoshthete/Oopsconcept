using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Anagram
    {
        static bool areAnagram(string str1,string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }
            char[] strchar1 = str1.ToLower().ToCharArray();
            char[] strchar2 = str2.ToLower().ToCharArray();
            Array.Sort(strchar1);
            Array.Sort(strchar2);
            for(int i = 0; i < strchar1.Length; i++)
            {
                if (strchar1[i].ToString() != strchar2[i].ToString())
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter second string");
            string str2= Console.ReadLine();
            if (areAnagram(str1, str2)==true)
            {
                Console.WriteLine("Are anagram");
            }
            else
            {
                Console.WriteLine("not anagram");
            }
        }
    }
}
