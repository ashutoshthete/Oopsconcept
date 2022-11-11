using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class passwordValidification
    {

        static void secondCondition(ref string[] input)
        {

        }
        static void Main(string[] args)
        {
            string check = "4dro6";
            string[] input = { "P@ssWORD1", "20passWORD20", "PASS6word", "ABCD428word" };
           
            string firstnumber = check.Substring(0, 1);
            string[] input2 = new string[] { };
            List<string> alphabetData = new List<string>();
            List<string> wordData = new List<string>();
            List<string> finalData = new List<string>();

            int firstdigit = int.Parse(firstnumber);
            string second = check.Substring(1, 3);
            string reversesecond = "";
            for (int i = second.Length - 1; i >= 0; i--)
            {
                reversesecond = reversesecond + second[i];
            }

            string last = check.Substring(check.Length - 1);
            int thirddigit = int.Parse(last);
            string[] newarr = new string[] { };
            int count = 0;
            for(int i = 0; i < input.Length; i++)
            {
                string strf = input[i];
                char[] ch = strf.ToCharArray();
                count = 0;
                for(int j = 0; j < ch.Length; j++)
                {
                    if(ch[j]>=65 && ch[j] <= 90)
                    {
                      
                        count++;
                    }
                }
                if (count == firstdigit)
                {
                    alphabetData.Add(input[i]); 
                    
                }
            }
            //second condtion
             foreach(string data in alphabetData)
            {
               
                if (data.EndsWith(reversesecond))
                {
                    
                    wordData.Add(data);

                }
            }
            //third condition
            int tp = 0,sum=0;
            int counter ;
            foreach (string thirdData in wordData)
            {
                char[] digitSearch = thirdData.ToCharArray();
                sum = 0;
                for(int i = 0; i < digitSearch.Length; i++)
                {
                    if (Char.IsDigit(digitSearch[i]))
                    { 
                        int incom = (int)Char.GetNumericValue(digitSearch[i]);
                        sum = sum + incom;
                    }

                }
                if (sum == thirddigit)
                {
                    finalData.Add(thirdData);
                }
                
            }
            foreach (string finalpassword in finalData)
            {
                Console.WriteLine("final password \n"+finalpassword);
            }




        }

    }
}
