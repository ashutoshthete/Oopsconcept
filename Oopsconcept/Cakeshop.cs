using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Cakeshop
    {
        static void Main(string[] args)
        {
            /*           *//* Console.WriteLine("Welcome to pie shop");

                        string name = Console.ReadLine();*/
            var monthlyWage = 1234;
            int months = 12, bonus = 1000;
            var isActive = true;
            var rating = 99.25;
            var numberofemployees = 300;
            int hoursWorked;
            hoursWorked = 125;
            hoursWorked = 148;

           /* const double interestRate = 0.07;
            string firstName = "Ashutosh";
            string lastName = "Thete";*/
            /* Console.WriteLine("Enter your name");
             string name1 = Console.ReadLine();*//*

             double ratePerHour = 12.34;


             double currentMonthWage = ratePerHour * numberOFHours+bonus;
             Console.WriteLine(currentMonthWage);
             ratePerHour += 3;
             Console.WriteLine(ratePerHour);

             if (currentMonthWage > 2000)
             {

                 Console.WriteLine("Top paide employees!");
             }
             int numberofemployees = 15;
             numberofemployees--;



             Console.WriteLine(numberofemployees);*/
            /*int intMaxValue = int.MaxValue;
            int intminValue = int.MinValue;

            char userSelection = 'a';
            char upperCaseVersion = char.ToUpper(userSelection);

            bool isDigit = char.IsDigit(userSelection);
            bool isLetter = char.IsLetter(userSelection);*/

            DateTime hirdate = new DateTime(2022, 3, 28, 14, 30, 0);
            Console.WriteLine(hirdate);

            DateTime exitdate = new DateTime(2025, 12, 11);
            DateTime startdate = hirdate.AddDays(15);
            Console.WriteLine(startdate);

            DateTime currentdate = DateTime.Now;
            bool areweindst = currentdate.IsDaylightSavingTime();

            DateTime starthour = DateTime.Now;
            TimeSpan worktime = new TimeSpan(8, 35, 0);
            DateTime endhour = starthour.Add(worktime);
            Console.WriteLine("\n");

            Console.WriteLine(starthour.ToLongDateString());
            Console.WriteLine(endhour.ToShortTimeString());
            /*
                        int numberOFHours = 165;

                        long verylongmonth = numberOFHours;

                        *//*double d = 123456789.0;
                       *//* int x = (int)d;*//*

                        Console.WriteLine("Enter the age of the new candidate :");
                        int Age = int.Parse(Console.ReadLine());
            */
            /* if (age < 18)
             {
                 Console.WriteLine("That person is too young to apply");
                 Console.WriteLine("send email to candidate");
             }
             else if(age>65)
             {
                 Console.WriteLine("Sorry the selcted age is too old");
                 Console.WriteLine("Send email to candidate");
             }
             else
             {
                 Console.WriteLine("great, you can now start with the application!");
             }
 */


            /*DateTime today = DateTime.Now;
            bool endofthemonthpayment = false;

            if (today.Date.Day == 20)
            {
                Console.WriteLine("please star end of month employee payments");
            }else if (today.Date.Day >= 25 && !endofthemonthpayment)
            {
                Console.WriteLine("payemnt will be late!");
            }

*/
            /* switch (Age)
             {
                 case 18:
                     Console.WriteLine("That person is too young to apply");
                     break;
             }*/
            /*Console.WriteLine("enter a number");
            int max = int.Parse(Console.ReadLine());
*/
            /* int i = 0;
             while (i < max)
             {
                 Console.WriteLine(i);
                 i++;
             }*/
            int i = 0;
            int j = 0;
            /*while (i < 10)
            {
                while (j < 10)
                {
                    Console.WriteLine("i: "+i+"   j: "+j);
                    j++;
                }
                j = 0;
                i++;
            }*/
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);

            int sum = 0;
            for(int c = 0; c < 10; c++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);



        }
    }
}
