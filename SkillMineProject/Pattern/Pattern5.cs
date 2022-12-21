using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Pattern
{
    class Pattern5
    {
       // output
       //1 
       //2 3 
       //4 5 6

       static void Main(string[]args)
        {
            Console.WriteLine("Enter  the number  of rows");
            int row = int.Parse(Console.ReadLine());
            int k = 1;
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write( k + "");
                    k++;
                }
                Console.WriteLine();
            }

        }
    }

    class Pattern55
    {
        // output
        //1 
        //2 3 
        //4 5 6

        static void Main(string[] args)
        {
            
            int k = 1;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(k + "");
                    k++;
                }
                Console.WriteLine();
            }

        }
    }

    class Pattern555
    {
        // output
        //1 
        //2 3 
        //4 5 6

        static void Main(string[] args)
        {

            int k = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(k + "");
                    k++;
                }
                Console.WriteLine();
            }

        }
    }

    class Class123456
    {

        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    count++;
                    Console.Write(count);
                }
                Console.WriteLine();
            }

        }
    }
}
