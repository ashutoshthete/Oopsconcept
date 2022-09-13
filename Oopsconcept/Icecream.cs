using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    interface Icecream
    {
        void eat();
        void drink();
        
    }
    interface juice
    {
        void drink();

    }
    class mastani : Icecream,juice
    {
        public void eat()
        {
            Console.WriteLine("Eat Your Mastani");
        }
        public void drink()
        {
            Console.WriteLine("drink Your mastani");
        }
        
    }
    class testicecream
    {
        static void Main(string[] args)
        {
            mastani m = new mastani();
            m.drink();
           
            m.eat();
        }
    }
}
