using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Gp
    {
        public virtual void m1()
        {
            Console.WriteLine("exercise on ground");
        }
    }
    class Pare:Gp
    {
       /* public sealed override void m1()
        {
            Console.WriteLine("gym");
        }*/
    }
    class child : Pare
    {
        public override void m1()
        {
            Console.WriteLine("dominoz");
        }
    }
    class Testgpc
    {
        static void Main(string[] args)
        {
            
            Gp gp = new Pare();
            gp.m1();
            child cv = new child();
            cv.m1();
        }
    }
}
