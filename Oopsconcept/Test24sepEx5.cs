using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Test24sepEx5
    {
        public static string commons(string s1,string s2)
        {
            StringBuilder commons = new StringBuilder();
            if(s1.Length>0 & s2.Length > 0)
            {
                string tobe = (s1.Length > s2.Length ? s2 : s1);
                string tobecheck = tobe.Equals(s1) ? s2 : s1;
                for(int i = 0; i < tobe.Length; i++)
                {
                    if (tobecheck.Contains(char.ToString(tobe[i])))
                    {
                        commons.Append(char.ToString(tobe[i]));
                    }
                }
                return commons.ToString();
            }
            else
            {
                return "";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter first string ");
            string s1 = Console.ReadLine();
            Console.WriteLine("enter the second string ");
            string s2= Console.ReadLine();
            Console.WriteLine("Common :"+commons(s1,s2));
        }
    }
}
