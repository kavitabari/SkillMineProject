using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.NestedLoop
{
    class SumOfPrimeNo
    {
        //check code not run 25_11
        static void Main(string[] args)
        {
            int sum = 0;
            

            for ( int num = 1; num <= 10; num++)
            {
                bool isPrime = true;
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime == true)
                {
                    Console.Write("...." + num);
                    sum = sum + num;
                }
                else /*(isPrime == false)*/
                {
                    Console.WriteLine("Sum Of Prime:=" + +sum);
                }
            }
        }
    }
}
