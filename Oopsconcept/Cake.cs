using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    interface Cake
    {
        void bake();
        void bakechocklate();
    }
    class baking : Cake
    {
        public void bake()
        {
            Console.WriteLine("Baking strawberry cake");
        }
        public void bakechocklate()
        {
            Console.WriteLine("Baking chocklate cake");
        }
    }
    class testCake
    {
        static void Main(string[] args)
        {
            baking bk = new baking();
            bk.bake();
            bk.bakechocklate();
        }
    }
}
