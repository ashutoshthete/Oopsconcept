using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept.DemoCollection
{
    class DemogenericDictionaryTkeyTvalue
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict =new Dictionary<string, int>();
            dict.Add("Riya", 90);
            dict.Add("diya", 88);
            dict.Add("Priya", 78);
            /* foreach(var d in dict)
             {
                 Console.WriteLine(d);
             }*/
            dict["Priya"] = 100;
            Console.WriteLine(dict.ContainsKey("diya"));
            dict.Remove("Riya");
           foreach(KeyValuePair<string,int> d in dict)
            {
                Console.WriteLine(d.Key+"=====>"+d.Value);
            }
            static void Main(string[] args)
            {
                Dictionary<Student, long> d2 = new Dictionary<Student, long>();
                d2.Add(new Student(1, "riya", 78), 9999999);
                d2.Add(new Student(2, "diya", 78), 9999999);
                d2.Add(new Student(1, "riya", 78), 9999999);
                foreach(KeyValuePair<Student,long> d in d2)
                {
                    Console.WriteLine(d.Key+"------>"+d.Value);
                }

            }
        }
    }
}
