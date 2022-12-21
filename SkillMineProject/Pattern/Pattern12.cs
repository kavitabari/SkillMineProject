using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Pattern
{

    //output
    //1234
    //123
    //12
    //1


    class Pattern12
    {
        static void Main(string[]args)
        {
            for (int i = 4; i >= 1; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern1234
    {
       
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  the Row");
            int row = int.Parse(Console.ReadLine());
            for (int i = 4; i >= row; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
