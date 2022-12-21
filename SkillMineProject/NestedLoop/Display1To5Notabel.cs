using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.NestedLoop
{
    //dipaly  no   1 to 5  between tabel
    class Display1To5Notabel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int num = int.Parse(Console.ReadLine());
           for(int i=1;i<=num;i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                   //Console.WriteLine(j * i);
                    Console.WriteLine(j + "*" + i + "=" + j * i);
                    Console.WriteLine("...................");
                }
                //Console.WriteLine(j + "*" + i"=" + j*i);
            }
          
        }
    }
}
