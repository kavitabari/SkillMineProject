using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Loops
{
    class sum1to10nocount
    {
        //calculate  the sum of 1 to 10 no
        static void  Main(string []arge)

        {
            int sum = 0;
           
            for(int i=0;i<=10;i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("sum of no is =" + sum);
            
        }
    }
}

