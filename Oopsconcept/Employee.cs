using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Employee
    {
        long employeeid;
        string employeename;
        long employeesalary;

        public long Employeeid
        {
            set { employeeid = value; }
            get { return employeeid; }
        }
        public String Employeename
        {
            set { employeename = value; }
            get { return employeename; }
        }
        public long Employeesalary
        {
            set { employeesalary = value; }
            get { return employeesalary; }
        }


        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Employeeid = 255980047;
            e1.Employeename = "Ashutosh Thete";
            e1.Employeesalary = 49500;

            Console.WriteLine("Employee ID- "+e1.Employeeid+"\nEmployee Name- "+e1.Employeename+"\nSalary- "+e1.Employeesalary);
        }

    }
}
