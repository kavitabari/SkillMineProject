using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.NestedLoop
{
    class CountOdd
    {

        static void Main(string[] args)
        {
            int i ,num ,odd = 0 ;
           // int count = 0;
          //  int sum = 0;
           // int even = 0, odd = 0;
            Console.WriteLine("Enter The Number");
            num = int.Parse(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    odd++;
                }
            }
            Console.WriteLine(odd);
        }
    }
}
