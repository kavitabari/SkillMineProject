using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Array
{
    class AverageElementOfArray
    {
        static void Main(string[]args)
        {
            int[] arr = { 1, 2, 6, 2, 18 };
            int i = 0;
            int sum = 0;
            float average = 0.0f;
                for (i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            average = (float)sum / arr.Length;
            Console.WriteLine("Average Elements Of Array:=" + average);

        }
    }
}
