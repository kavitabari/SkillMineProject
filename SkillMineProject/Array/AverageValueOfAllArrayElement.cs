using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Array
{
    class  AverageValueOfAllArrayElement
    {
        public void SumAvergeElements(int[]arr,int size)
        {
            int sum = 0;
            int averge = 0;
            for(int i = 0; i < size; i++)
            {
                sum = arr[i];
            }
            averge = sum / size;
            Console.WriteLine("Sum Of Array Is:=" + sum);
            Console.WriteLine("Average Of Array Is:=" + averge);
            Console.ReadLine();
        }
        public static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter The size:+");
            size = int.Parse(Console.ReadLine());
            int[]a = new int[size];
            Console.WriteLine("Enter the element of the array:");
            for(int i = 0; i < size; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int len = a.Length;
            AverageValueOfAllArrayElement  avr = new AverageValueOfAllArrayElement();
            avr.SumAvergeElements(a, len);

        }

    }
}
