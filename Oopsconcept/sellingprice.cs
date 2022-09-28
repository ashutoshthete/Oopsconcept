using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class sellingprice
    {
        static float sellingp(float cprice,float noitem,float profit)
        {
            float selling = cprice * (profit /100);
            selling = selling + cprice;

            return selling;
        }
        static void Main(string[] args)
        {
            float cprice = float.Parse(Console.ReadLine());
            float noitem = float.Parse(Console.ReadLine());
            float profit = float.Parse(Console.ReadLine());
            Console.WriteLine(sellingp(cprice,noitem,profit));
        }
    }
}
