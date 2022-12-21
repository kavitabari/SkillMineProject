using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Array
{
    class FindMaxElementUsingArray
    {

        public int FindMax(int[] a)
        {
            int max = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            return max;
        }



        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 7, 2, 9, 1 };
            FindMaxElementUsingArray m = new FindMaxElementUsingArray();
            Console.WriteLine("Max From Element:=" + m.FindMax(arr));


        }

    }
}
