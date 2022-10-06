using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Cuckoo__series
    {
        int coo(int n)
        {
            if (n == 1)
                return 0;
            if (n == 2)
                return 1;
            else return 1 * coo(n - 1) + 2 * coo(n - 2) + 3 * 1;
        }
        static void Main(string[] args)
        {
            Cuckoo__series c = new Cuckoo__series();
            Console.WriteLine("enter input");
            int n = int.Parse(Console.ReadLine());
            int result = c.coo(n);
            Console.WriteLine(result);
           
        }
       
    }
}
        