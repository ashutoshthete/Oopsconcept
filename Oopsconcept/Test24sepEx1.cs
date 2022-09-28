using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Test24sepEx1
    {
        static void Main(string[] args)
        {
            int d, i, n = 5;
            for (i = 1; i <= n; i++)
            {
                d = i * i * i + i;
                Console.WriteLine(d);
            }

        }
    }
}
