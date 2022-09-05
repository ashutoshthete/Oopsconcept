using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class TestExercise2
    {
        public static int sumofd(int num)
        {
            int a = 0;
            while (num > 0)
            {
                a = a + num % 10;
                num = num / 10;
            }

            return a;
        }
        public static bool isvalidIMEI(long num)
        {
            String s = num.ToString();
            int len = s.Length;

            if (len != 15)
                return false;

            int sum = 0;
            for (int i = len; i >= 1; i--)
            {
                int d = (int)(num % 10);

                
                if (i % 2 == 0)
                    d = 2 * d;

                
                sum += sumofd(d);
                num = num / 10;
            }

            return (sum % 10 == 0);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the IMEI num : ");
            long num = long.Parse(Console.ReadLine());

            if (isvalidIMEI(num))
            {
                Console.WriteLine("valid IMEI number");
            }
            else
            {
                Console.WriteLine("invalid IMEI number");
            }
        }
    }
}
