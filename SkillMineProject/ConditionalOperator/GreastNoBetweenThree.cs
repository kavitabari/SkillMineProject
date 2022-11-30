using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalOperator
{
    class GreastNoBetweenThree
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num3");
            int num3 = int.Parse(Console.ReadLine());
            
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("num1 Is Greater");

                }
                else
                {
                    Console.WriteLine("num2 Is Greater");
                }
               
            }
            else
            {
                Console.WriteLine("num3 Is Greater");
            }




        }
    }
}
