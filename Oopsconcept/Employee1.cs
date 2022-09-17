using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Employee1
    {
        string name;
        int eid;
        int mgid;
        string mname;

        public Employee1(string name, int eid, int mgid, string mname)
        {
            this.name = name;
            this.eid = eid;
            this.mgid = mgid;
            this.mname = mname;
        }

        public string Name { get => name; set => name = value; }
        public int Eid { get => eid; set => eid = value; }
        public int Mgid { get => mgid; set => mgid = value; }
        public string Mname { get => mname; set => mname = value; }

        public void showdata()
        {
            Console.WriteLine("Employee name : "+Name+"\nEmployee id : "+Eid+"\nManager id : "+Mgid+"\nMangaer name : "+Mname);
        }
    }
    class testemp
    {
        static void Main(string[] args)
        {

            Employee1[] emp = new Employee1[5];

            emp[0] = new Employee1("ashutosh", 255, 1745, "atul\n");
            emp[1] = new Employee1("arivind", 256, 1745, "atul\n");
            emp[2] = new Employee1("gauri", 257, 1745, "atul\n");
            emp[3] = new Employee1("amit", 258, 1745, "atul\n");
            emp[4] = new Employee1("anup", 259, 1745, "atul\n");


            Console.WriteLine("Employee 1:");
            emp[0].showdata();
            Console.WriteLine("Employee 2:");
            emp[1].showdata();
            Console.WriteLine("Employee 3:");
            emp[2].showdata();
            Console.WriteLine("Employee 4:");
            emp[3].showdata();
            Console.WriteLine("Employee 5:");
            emp[4].showdata();
        }
    }
}
