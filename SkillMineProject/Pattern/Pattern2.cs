using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Pattern
{


    class Pattern2
    {
        //output
        //1
        //12
        //123
        //1234
        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + "");
                }
                Console.WriteLine();
            }

        }
    }

    class Pattern22
    {
        //output
        //1
        //12
        //123
        //1234
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  the number  of rows");
            int row = int.Parse(Console.ReadLine());
            //int k = 1;
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + "");
                }
                Console.WriteLine();
            }

        }
    }
}
