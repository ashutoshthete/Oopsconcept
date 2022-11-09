using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Class20
    {
        static void Main(string[] args)
        {
            static int closestnum(int[] arr,int closest)
            {
                int size = arr.Length;
                if (closest <= arr[0])
                {
                    return arr[0];
                }
                if (closest >= arr[size - 1])
                {
                    return arr[size - 1];
                }
                    int i = 0, j = size, mid = 0;
                    while (i < j)
                    {
                        mid = (i + j) / 2;
                        if (arr[mid] == closest)
                        
                            return arr[mid];
                        
                        if (closest < arr[mid])
                        {
                            if(mid>0&& closest < arr[mid - 1])
                            
                                return getsclosest(arr[mid-1], arr[mid], closest);

                            j = mid;

                        }
                        else
                        {
                            if (mid < size - 1 && closest < arr[mid + 1])
                                return getsclosest(arr[mid], arr[mid + 1], closest);

                            i = mid + 1;
                        }
                    }
                return arr[mid];
            }
             static int getsclosest(int val,int val2,int closest)
            {
                if (closest - val >= val2 - closest)
                    return val2;
                else
                    return val;
               
            }
            int[] arr = { 3, 4, 7, 32, 56, 42 };
            int closest = int.Parse(Console.ReadLine());
            Console.WriteLine(closestnum(arr,closest));

        }
    }
}
