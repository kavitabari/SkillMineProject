using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Array
{
    class OddNumberFromArrayUsingInteger
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] arr = new int[5];//declare aaray  of integer
            Console.WriteLine("Enter  array elements");
            i = int.Parse(Console.ReadLine());
            // arr[i] = int.Parse(Console.ReadLine());
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("Element ["+ (i + 1)+"]:");
                arr[i] = int.Parse(Console.ReadLine());
            }
             Console.WriteLine("List of odd number:=");
                for (i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        Console.WriteLine(arr[i] + "");
                    }
                }
                Console.WriteLine();
            
           
        }
    }
}
