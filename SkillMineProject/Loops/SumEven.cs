using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Loops
{
    class SumEven
    {
       static void Main(string[]args)
        {
            int sum = 0;
            for(int i = 1; i <= 10; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum:=" + sum);
        }
    }
}
