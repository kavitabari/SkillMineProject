using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.WhileLoop
{
    //write code toperform the sum of 1 to20 no if the sum value is greater than 10where stop perform the  addition
    class SumOf_1to20NoIfThe_SumValueIsGreateThan10StopPerformTheOperation
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i = 1; i <= 20; i++)
            {
                sum = sum + i;
                if (sum >10) //(sum == 10)
                {
                    break;
                }
                Console.WriteLine(sum);
            }
          //  Console.ReadLine();
        }
    }
    class SumOf_1to20NoIfThe_SumValueIsGreateThan10StopPerformTheOperation1
    {
        static void Main(string[] args)
        {
            int sum = 0,i=0;
           while(i<=20)
            {
                sum = sum + i;
                if (sum > 10)
                {
                    break;
                }
                i++;
                Console.WriteLine(sum);
            }
            Console.ReadLine();
        }
    }
}
