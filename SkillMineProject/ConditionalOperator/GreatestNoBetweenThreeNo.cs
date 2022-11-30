using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalOperator
{
    class GreatestNoBetweenThreeNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The First No");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Second No");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Third No");
            int num3 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("No Is Greater:=" + num1);
                }
                else
                {
                    Console.WriteLine("No Is Greater:=" + num3);
                }
            }
            else if (num2 > num1)
            {
                if (num2 > num3)
                {
                    Console.WriteLine("No Is Greater:=" + num2);
                }
                else
                {
                    Console.WriteLine("No Is Greater:=" + num3);
                }
            }
        }
    }
}
