using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Array
{
    class ReversearrayElementArray
    {
        static void Main(string[] args)
        {
            int i= 0;
            int j = 0;
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            Console.WriteLine("Enter The Number");
            i = int.Parse(Console.ReadLine());
            for(i=0;i<5;i++)
            {
                Console.Write("Element [" + (i + 1) + "]:");
                arr1[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0, j = arr1.Length - 1; i < arr1.Length; i++)
            {
                arr2[i] = arr1[j--];
            }
            Console.WriteLine("Reverse Element:=");
            //8Console.WriteLine();
            for (i = 0;i < 5; i++)
            {
                Console.WriteLine();
                Console.Write("Element [" + (i + 1) + "]:"+arr2[i]);
               // arr2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }
    }
}
