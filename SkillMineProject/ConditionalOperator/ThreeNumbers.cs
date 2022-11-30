using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalOperator
{
    class ThreeNumbers
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the mum1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num3");
            int num3 = int.Parse(Console.ReadLine());
            int max = 0;
            if(num1>num2)
            {
                if (num1 > num3)
                {
                    max = num1;
                }
                else
                {
                    max = num3;
                }
           }
            
            else if(num2>num3)
            {
                max = num2;
            }
            else
            {
                max = num3;
            }
            
            Console.WriteLine("max no" + max);
            int g = (num1 > num2) ? (num2 > num3 ? num1 : num3) : (num2 > num3 ? num2 : num3);
            Console.WriteLine("largest no is" + g);
        }
    }
}
