using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Loops
{
    class divisible_by_3to5between1to50
    {
        static void Main(string[]args)
        {
            for(int i=1;i<=50;i++)
            {
                if(i%3==0 && i % 5 == 0)
                {
                    Console.WriteLine(i);

                }
                
            }
        }
    }
}
