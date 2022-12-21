using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Array
{
    class FindMinElementArray
    {
        public int FindMin(int[] a)
        {
            int min = 1;
            for (int i = 0; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            return min;
        }



        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 7, 2, 9, 1 };
            FindMinElementArray m = new FindMinElementArray();
            Console.WriteLine("Min From Element:=" + m.FindMin(arr));


        }

    }
}

