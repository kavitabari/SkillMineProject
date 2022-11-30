using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.WhileLoop
{
    class Displayno1t050_justkeepthenodivisibleby5
    {
        static void  Main(string[]args)
        {
            Console.WriteLine("Print the no  of 1 to 50 just keep  divisible by 5");
            int i = 1;
            while (i < 50)
            {
                if (i % 5 == 0)
                {
                    i++;
                    continue;
                }Console.WriteLine(i);
                i++;
            }
           // Console.ReadLine();
        }
    }

    class Displayno1t050_justkeepthenodivisibleby511
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print the no  of 1 to 50 just keep  divisible by 5");
            
            for(int i=1;i<=50;i++)
            {
                if (i % 5 == 0)
                {
                   // i++;
                    continue;
                }
                Console.WriteLine(i);
               // i++;
            }
            // Console.ReadLine();
        }
    }
}
