using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Person
    {
        int id;
        string name;
        Vehicle v;
        public Person(int id,string name,Vehicle v)
        {
            this.id = id;
            this.name = name;
            this.v = v;
        }
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public Vehicle V
        {
            set { v = value; }
            get{ return v; }
        }

    }
    class Vehicle
    {
        int vid;
        string vname;
        public Vehicle(int vid,string vname)
        {
            this.vid = vid;
            this.vname = vname;
        }
        public int Vid
        {
            set { vid = value; }
            get { return vid; }
        }
        public string Vname
        {
            set { vname = value; }
            get { return vname; }
        }
       

    }
    class Testperson
    {
        static void Main(string[] args)
        {
            Person p = new Person(255, "ashutosh thete", new Vehicle(2579, "honda"));
            Person p2 = new Person(266, "Vijay singh", new Vehicle(2557, "TVS"));
            Console.WriteLine("Person id : "+p.Id+"\nPerson Name : "+p.Name+"\nVehicle id : "+p.V.Vid+"\nVehicle Name : "+p.V.Vname);
            Console.WriteLine("\n");
            Console.WriteLine("Person id : " + p2.Id + "\nPerson Name : " + p2.Name + "\nVehicle id : " + p2.V.Vid + "\nVehicle Name : " + p2.V.Vname);
        }
    }
}
