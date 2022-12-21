using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Array
{
    class PositiveAndNegativeNumberOfArray
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] a = new int[10];
            Console.WriteLine("Enter the element");
           // i = int.Parse(Console.ReadLine());
            for (i = 0; i < 5; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                if (a[i] > 0)
                    a[i] = -a[i];
            }
            Console.WriteLine("Elemets");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
        }
    }
}
