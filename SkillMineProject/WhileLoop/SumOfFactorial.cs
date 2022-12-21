using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.WhileLoop
{
    class SumOfFactorial
    {//not run
        static void  Main(string[]args)
        {
            int fact = 1;
            int sum = 0;
            //Console.WriteLine("Enter The No");
           // int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 5; i++)
            {
                while(i>=0)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                int temp = sum;
                Console.WriteLine("sum" + temp);
            }
           
        }
    }
}
