using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.NestedLoopDemo
{
    class NestedLoopDemoPattern
    {
       static void  Main(string[]args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=2;j++)
                {
                    Console.WriteLine(j);
                }
            }

        }
    }
}
