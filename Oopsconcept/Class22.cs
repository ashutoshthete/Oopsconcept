using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Class22
    {
        static void findmissingnumber(int[]arr)
        {
            int sum = (arr.Length + 1) * (arr.Length + 2) / 2;
            for(int i = 0; i < arr.Length; i++)
            {
                sum = sum - arr[i];
            }
            Console.WriteLine("missing : "+sum);

        }
        static void Main(string[] args)
        {
            int[] arr = new int[9];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            findmissingnumber(arr);
        }
    }
    class explainap
    {
        public int nthterm(int input1, int input2, int input3)
        {
            int d = input2 - input1;
            for(int i = 4; i <= input3; i++)
            {
                input2 = input2 + d;
            }
            return input2;
        }
        static void Main(string[] args)
        {
            explainap eap = new explainap();
            int input1 = 1;
            int input2 = 2;
            int input3 = 4;
            int result =eap.nthterm(input1, input2, input3);
            Console.WriteLine(result);

        }
    }
    class progrmiz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first term ");
            int firstTerm = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter common difference");
            int commonDifference = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the nth term");
            int numberOfTerms = int.Parse(Console.ReadLine());
            int arithmeticSeries = 0;
            for (int i = 0; i < numberOfTerms; i++)
            {
                arithmeticSeries = firstTerm + i * commonDifference;
                Console.WriteLine( arithmeticSeries);
            }
        }
    }
}
