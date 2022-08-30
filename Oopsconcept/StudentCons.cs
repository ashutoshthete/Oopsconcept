using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class StudentCons
    {
        string name;
        int rollno;
        public StudentCons(string name,int rollno)
        {
            this.name = name;
            this.rollno = rollno;
        }
        public static void Main(string[] args)
        {
            StudentCons stc = new StudentCons("ashutosh", 808);
            StudentCons stc1 = new StudentCons("ravi", 312);
            StudentCons stc2 = new StudentCons("harsh", 545);

            Console.WriteLine(stc.name+"  "+stc.rollno);
            Console.WriteLine(stc1.name+"  "+stc1.rollno);
            Console.WriteLine(stc2.name+"  "+stc2.rollno);
        }
    }
}
