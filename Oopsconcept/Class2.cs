using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Class2
    {

        public static bool isPalindrome(int num)
        {
            int copy = num;
            int r;
            int rev = 0;
            while (num > 0)
            {
                r = copy % 10;
                copy = copy / 10;
                rev = rev * 10 + r;
            }
            return rev == num;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            if (isPalindrome(num))
            {
                Console.WriteLine("palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }
        }
    }
}
