using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept.StringExercise
{
    class Class1
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Enter string");
            string s = Console.ReadLine();
            string rev = "";
            Console.WriteLine("\n");
            Console.WriteLine("The vowels are: ");
            int count = 0;
            for(int i = 0; i < s.Length; i++)
            {
                
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                {
                    Console.WriteLine(s[i]);
                    count++;
                   
                }
            }
            Console.WriteLine("The count of vowel is : "+count);
            Console.WriteLine("Reverse of string : ");
            for(int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
            Console.WriteLine("\n");
            for(int i = s.Length - 1; i >= 0; i--)
            {
                rev = rev + s[i];
            }
            if (rev == s)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }*/
            string sm = "ASHUtosh";

            string res = "";
            for (int i = 0; i < sm.Length; i++)
            {
                if (char.IsUpper(sm[i]))
                {
                    res = res + char.ToLower(sm[i]);
                }
                else
                {
                    res = res + char.ToUpper(sm[i]);
                }
            }
            Console.WriteLine(res);
        }
    }
}
