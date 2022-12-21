using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Array
{
    class SmallElementFromIntegerArray
    {
        static void Main(string[] args)
        {
            int i = 0;
            int small = 0;
            int[] arr = new int[5];//declare aaray  of integer
            Console.WriteLine("Enter  array elements");
            i = int.Parse(Console.ReadLine());
            // arr[i] = int.Parse(Console.ReadLine());
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("Element [" + (i + 1) + "]:");
                arr[i] = int.Parse(Console.ReadLine());
            }
            small = arr[0];
            for (i = 0; i < arr.Length; i++)
            {
                if (small > arr[i])
                    small = arr[i];
            }
            Console.WriteLine("Smallest Element in array:" + small);


        }
    }
}
