using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.NestedLoop
{
    class PrimeNoNestedLoop
    {

        static void Main(string[]args)
        {
            int i, num, count = 0;
            Console.WriteLine("Enter The Prime NO");
            num = int.Parse(Console.ReadLine());
            for( i=2;i<=num;i++)
            {
                if(num%2==0)
                {
                    count++;
                    break;
                }
            }
            Console.WriteLine("count:=" + count);
            if (count == 0 && num != 1)
            {
                Console.WriteLine("It Is  Prime:=" + num);
            }
            else
            {
                Console.WriteLine("It Is Not Prime:=" + num);
            }
        }
    }
}
