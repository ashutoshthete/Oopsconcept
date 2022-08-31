using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Disarium
    {
        public int Power(int b,int index)
        {
            int result = 1;
            for(int i = 1; i <= index; i++)
            {
                result = result * b;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Disarium ds = new Disarium();
            
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());

            int copy = num;
            int r = 0;
            int count = 0;
            int sum = 0;
           
            while (num != 0)
            {

                count++;
                num = num / 10;


            }
            num = copy;
            while (num > 0)
            {
               
                r = num % 10;
                sum = sum + ds.Power(r, count);
                    count--;
                num = num / 10;
                
            }
            if (sum == copy)
            {
                Console.WriteLine("The number is Disarium");
            }
            else
            {
                Console.WriteLine("the number is not Disarium");
            }
 
        }
    }
}
