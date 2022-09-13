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
        public override string ToString()
        {
            return "name : " + name + "\nroll no : " + rollno+"\n";
        }
        public static void Main(string[] args)
        {
            StudentCons stc = new StudentCons("ashutosh", 808);
            Console.WriteLine(stc);
            StudentCons stc1 = new StudentCons("ravi", 312);
            Console.WriteLine(stc1);
            StudentCons stc2 = new StudentCons("harsh", 545);
            Console.WriteLine(stc2);

            StudentCons stc3 = new StudentCons("anup", 808);
            Console.WriteLine(stc3);
            StudentCons stc4 = new StudentCons("anuj", 312);
            Console.WriteLine(stc4);
            StudentCons stc5 = new StudentCons("sandip", 545);
            Console.WriteLine(stc5);

            StudentCons stc6 = new StudentCons("anil", 808);
            Console.WriteLine(stc6);
            StudentCons stc7 = new StudentCons("neha", 312);
            Console.WriteLine(stc7);
            StudentCons stc8 = new StudentCons("arun", 545);
            Console.WriteLine(stc8);


        }
    }
}
