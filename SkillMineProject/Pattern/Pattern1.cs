using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Pattern
{
    class Pattern1
    {
        //output
        //1234
        //1234
        //1234
        //1234
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write("" +j);
                }
                Console.WriteLine();
            }


        }
    }

    class Pattern11
    {
        //output
        //1234
        //1234
        //1234
        //1234
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The  No Of  Rows");
            int row = int.Parse(Console.ReadLine());
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row; j++)
                {
                    Console.Write(j+ "");
                }
                Console.WriteLine();
            }


        }
    }
}
