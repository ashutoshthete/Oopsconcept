using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Palindrome
    {
        int sum = 0;
        public int palindrome(int num)
        {
            while (num > 0)
            {
                int r = num % 10;
                sum = (sum * 10) + r;
                num = num / 10;
            }
            return sum;
        }
        public static void Main(string[] args)
        {
            Palindrome p = new Palindrome();
            Console.WriteLine("Enter the number ");
            int num=int.Parse(Console.ReadLine());
            int copy = num;
            int result = p.palindrome(num);
           
            
            if (copy == result)
            {
                Console.WriteLine("The number is palindrome");
            }
            else
            {
                Console.WriteLine("The number is not palindrome");
            }


        }
    }
    class palindrom2
    {
        public static int checkpalindrome(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int r = num % 10;
                sum = (sum * 10) + r;
                num = num / 10;

            }
            return sum;
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            if (temp == checkpalindrome(num))
            {
                Console.WriteLine("Thenumber is palindrome");
            }
            else
            {
                Console.WriteLine("The number is not  palindrome");
            }
        }
    }
    class palindrome3
    {
        public string palindrome(string str)
        {
            string reverse = string.Empty;
           for(int i = str.Length - 1; i >= 0; i--)
            {
                reverse = reverse + str[i];
            }
            return reverse;
        }
        static void Main(string[] args)
        {
            palindrome3 pln = new palindrome3();
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            string result = pln.palindrome(str);
            if (result == str)
            {
                Console.WriteLine("is palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }

        }
    }
    class palindrome4
    {
        public static string checkpalindrome(string str)
        {
            string reverse = string.Empty;
            for(int i = str.Length - 1; i >= 0; i--)
            {
                reverse = reverse + str[i];
            }
            return reverse;
        }
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();

            if (str == checkpalindrome(str))
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
