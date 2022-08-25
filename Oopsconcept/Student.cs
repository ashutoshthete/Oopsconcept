using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Student
    {

        string name;
        double percentage;
        string qualification;
        int passyear;


        public void Setname(string nm)
        {
            name = nm;
        }
        public void Setpercentage(double pr)
        {
            percentage = pr;
        }
        public void Setqualification(string qual)
        {
            qualification = qual;
        }
        public void Setpassyear(int py)
        {
            passyear = py;
        }


        public string Getname()
        {
            return name;
        }

        public double Getpercentage()
        {
            return percentage;
        }

        public string Getqualification()
        {
            return qualification;
        }

        public int Getpassyear()
        {
            return passyear;
        }


        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Setname("Ashutosh Thete");
            s1.Setpassyear(2018);
            s1.Setqualification("B.tech");
            s1.Setpercentage(81.68);
            Console.WriteLine("Name= "+s1.Getname()+"\nPass out Year="+s1.passyear+"\nQualification="+s1.Getqualification()+"\nPercentage="+s1.Getpercentage());
            




        }
    }
}
