using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Pattern
{
    class PatternStarand_Zero
    {

        //output
        //*
        //*0
        //*0*
        //*0*0
       static void Main(string[] args)
       {
            // int count = 0;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (j == 1 || i == 3 && j == 3 || i == 4 && j == 3)
                    {
                        Console.Write("*");
                    }
                    else if (i == 2 && j == 2 || i == 3 && j == 2 || i == 4 && j == 2 || i == 4 && j == 4)
                    {
                        Console.Write(0);
                    }
                    else
                    {
                        Console.Write("");
                    }
                }
                Console.WriteLine();

            }

       }

    }
    class patteenrstarstar
    {
        static void Main(string[] args)
        {
            // int count = 0;
            Console.WriteLine("Enter the row");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row; j++)
                {
                    if (j == 1 || i == 3 && j == 3 || i == 4 && j == 3)
                    {
                        Console.Write("*");
                    }
                    else if (i == 2 && j == 2 || i == 3 && j == 2 || i == 4 && j == 2 || i == 4 && j == 4)
                    {
                        Console.Write(0);
                    }
                    else
                    {
                        Console.Write("");
                    }
                }
                Console.WriteLine();

            }

        }
    }
}
