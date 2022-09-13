using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class PP
    {
        public virtual void  m1()
        {
            Console.WriteLine("hi");
        }
    }
    class CC : PP
    {
        public override void  m1()
        {
            Console.WriteLine("hello");
        }
    }
    class TEstP
    {
        static  void Main(string[] args)
        {
            /*PP op = new PP();
            op.m1();*/


            PP vb = new CC();
            vb.m1();

           /* CC cp = new CC();
            cp.m1();
*/

        }
    }
}
