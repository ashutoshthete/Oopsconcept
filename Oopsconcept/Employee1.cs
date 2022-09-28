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
        /*string mname;*/

        public Employee1(string name, int eid, int mgid/*, string mname*/)
        {
            this.name = name;
            this.eid = eid;
            this.mgid = mgid;
            /*this.mname = mname;*/
        }

        public string Name { get => name; set => name = value; }
        public int Eid { get => eid; set => eid = value; }
        public int Mgid { get => mgid; set => mgid = value; }
        
       /* public string Mname { get => mname; set => mname = value; }*/

        /*public void showdata()
        {
            Console.WriteLine("Employee name : "+Name+"\nEmployee id : "+Eid+"\nManager id : "+Mgid+"\nMangaer name : "+Mname);
        }*/
        public override string ToString()
        {
            
            return "Employee name : " + Name + "\nEmployee id : " + Eid + "\nManager id : " + Mgid + "\nManager Name : \n";
        }
    }
    class testemp
    {
        static void Main(string[] args)
        {

            Employee1[] emp = new Employee1[5];

            for(int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine("enter employee name,id and manger id,name:");
                string name = Console.ReadLine();
                int eid = int.Parse(Console.ReadLine());
                int mgid = int.Parse(Console.ReadLine());
                
               
                emp[i] = new Employee1(name, eid, mgid);

            }
            for(int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine(emp[i]);
            }
            foreach(Employee1 e in emp)
            {
                foreach(Employee1 m in emp)
                {
                    if (e.Mgid == m.Eid)
                    {
                        Console.WriteLine($"employee name :{ e.Name}\nMannager name : {m.Name}\n");
                    }
                }
            }
            /*emp[0] = new Employee1("ashutosh", 255, 1745, "atul\n");
            emp[1] = new Employee1("arivind", 256, 1745, "atul\n");
            emp[2] = new Employee1("gauri", 257, 1745, "atul\n");
            emp[3] = new Employee1("amit", 258, 1745, "atul\n");
            emp[4] = new Employee1("anup", 259, 1745, "atul\n");
            Console.WriteLine(emp[0]);*/


            /*Console.WriteLine("Employee 1:");
            emp[0].showdata();
            Console.WriteLine("Employee 2:");
            emp[1].showdata();
            Console.WriteLine("Employee 3:");
            emp[2].showdata();
            Console.WriteLine("Employee 4:");
            emp[3].showdata();
            Console.WriteLine("Employee 5:");
            emp[4].showdata();*/
        }
    }
}
