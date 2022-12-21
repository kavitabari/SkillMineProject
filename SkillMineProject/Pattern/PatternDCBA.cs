using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Pattern
{
    class PatternDCBA
    {
      //output
      // DCBA
      //DCB
      // DC
      //D
        static void Main(string[]args)
        {
            for(char i='A';i<='D';i++)
            {
                for (char j = 'D'; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

    }

    class PaterrDCBAA
    {
        //output
        //Enter The  Row
        //  4
        //DCBA
        //DCB
        //DC
        //D

        static void Main(string[] args)
        {
            Console.WriteLine("Enter The  Row");
            int row = int.Parse(Console.ReadLine());
            for (char i = 'A'; i <= 'D'; i++)
            {
                for (char j = 'D'; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    class ClassDDCBA
    {

        static void Main(string[] args)
        {
            // int count = 0;
            for (char i = 'D'; i >= 'A'; i--)
            {
                for (char j = i; j >= 'A'; j--)
                {
                    //count++;
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }
    }
}
