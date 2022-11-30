using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.NestedLoopDemo
{
    class Patternrow4andcolun4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("/////////////////////////////////");

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("/////////////////////////////////");

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; i++)
                {
                    Console.Write(1);
                }
                Console.WriteLine();
            }

            Console.WriteLine("/////////////////////////////////");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; i++)
                {
                    if(i==1||j==1||i==5||j==5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("/////////////////////////////////");
            for (int i = 'A'; i <= 'D'; i++)
            {
                for (int j = 'A'; j <= 'D'; i++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            Console.WriteLine("/////////////////////////////////");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; i++)
                {

                    Console.Write((char)(j+64));
                  
                   
                    
                }
                Console.WriteLine();
            }
        }
    }

    }
     
