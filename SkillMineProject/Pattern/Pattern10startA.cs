using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Pattern
{
    class Pattern10startA
    {
       
      
            //output
            //A
            //AB
            //ABC
            //ABCD



            static void Main(string[] args)
            {
                // int count = 0;
                for (char i = 'A'; i <= 'D'; i++)
                {
                    for (char j = 'A'; j <= i; j++)
                    {
                        //count++;
                        Console.Write(j);
                    }
                    Console.WriteLine();
                }

            }
        
    }
    class patternStartA
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the row");
            //int row = int.Parse(Console.ReadLine());
            // int count = 0;
            for (char i = 'A'; i <= 'D'; i++)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    //count++;
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }

    }
}
