using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept.StringExercise
{
    class Class2
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Ashutosh");
            sb.Append("Thete");
            sb.AppendLine("godsfav");
            sb.Append("amol");
            sb.Insert(0, "lucifer");
            sb.Remove(1, 5);
            string str = sb.ToString();

            string s1 = "aman";
            string s2 = "ram";
            Console.WriteLine(s1.CompareTo(s2));

            Console.WriteLine(sb.Capacity);
        }
    }
    class rev
    {
        static void Main(string[] args)
        {
            string str = "my56name57id8ashu78al";
            int sum = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if(str[i]>='0'&& str[i] <= '9')
                {
                    sum= sum + (str[i] - '0');
                }
            }
            Console.WriteLine("sume of digit : "+sum);
        }
    }
}
