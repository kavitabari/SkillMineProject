using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalOperator
{
    class ConditionalDemo
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter The Num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Num2");
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("num1 is Grater");

            }
            else
            {
                Console.WriteLine("num2 is Grater");
            }
        }
    }
}
