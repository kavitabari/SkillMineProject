using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.WhileLoop
{
    class ArmstrongNo
    {
        //chek no  is armstrong number or not
        static void  Main(string []args)
        {
            Console.WriteLine("Enter The No");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum = sum + (digit * digit * digit);
                num = num / 10;
            }
            num = temp;
            if (num == sum)
            {
                Console.WriteLine("Number Is Armstrong");
            }
            else
            {
                Console.WriteLine("Number Is Not Armstrong");
            }

        }
    }
}
