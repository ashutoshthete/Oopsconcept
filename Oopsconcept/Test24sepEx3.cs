using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Test24sepEx3
    {
        bool isIncreasing(int n)
        {
            string s =n.ToString();
            char ch;
            int f = 0;
            for (int i = 0; i < s.Length- 1; i++)
            {
                ch = s[i];
                if (ch > s[i + 1])
                {
                    f = 1;
                    break;
                }
            }
            if (f == 1)
                return false;
            else
                return true;
        }

        bool isDecreasing(int n)
        {
            String s =n.ToString();
            char ch;
            int f = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                ch = s[i];
                if (ch < s[i + 1])
                {
                    f = 1;
                    break;
                }
            }
            if (f == 1)
                return false;
            else
                return true;
        }

        void isBouncy(int n)
        {
            if (isIncreasing(n) == true)
                Console.WriteLine("The number " + n + " is Increasing and Not Bouncy");
        else if (isDecreasing(n) == true)
                Console.WriteLine("The number " + n + " is Decreasing and Not Bouncy");
        else
                Console.WriteLine("The number " + n + " is bouncy");
        }

        public static void Main(string[]args)
        {

            Test24sepEx3 ob = new Test24sepEx3();
            Console.WriteLine("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            ob.isBouncy(n);

        }
    }
}
