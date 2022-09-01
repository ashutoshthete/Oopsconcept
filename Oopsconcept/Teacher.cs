using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Teacher
    {
        long tid;
        string tname;
        long mobileno;
        

        public Teacher(long tid, string tname, long mobno)
        {
            this.tid = tid;
            this.tname = tname;
            this.mobileno = mobno;
        }
        public long Tid
        {
            set { tid = value; }
            get { return tid; }
        }
        public string Tname
        {
            set { tname = value; }
            get { return tname; }
        }
        public long Mobno
        {
            set { mobileno = value; }
            get { return mobileno; }
        }

    }
    class Hourlybased
    {
        int rateperhour;
        int hrs;
        
        public Hourlybased(int rateperhour,int hrs)
        {
            this.rateperhour = rateperhour;
            this.hrs = hrs;

        }
    }
    class Salarybased
    {
        int salary;

        public Salarybased(int salary)
        {
            this.salary = salary;
        }
        static void Main(string[] args)
        {
            Teacher t = new Teacher(2021275458, "ravi sir", 94564651225);
            Hourlybased hb = new Hourlybased(2000,2);
            Teacher t2 = new Teacher(201548654, "arun sir", 945245458);

        }
    }
    
}
