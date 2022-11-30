using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.NestedLoopDemo
{
    //dipaly  no   1 to 5  between tabel
    class Display1To5Notabel
    {
        static void Main(string[] args)
        {
            int i,j,n=0;
            for (i = 1; i <= 10; i++)
            {
               for (j = 1; j <=10; i++)
               {
                   
                    if(i<=n-1 )
                    {
                        Console.WriteLine(i * 2);
                    }
                    else
                    {
                        Console.WriteLine(j * 2);
                    }
                }
               Console.WriteLine("\n");

            }
           // Console.WriteLine();
        }
    }
}
