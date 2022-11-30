using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.NestedLoop
{
    class DisariumNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The number");
            int num = int.Parse(Console.ReadLine());
            int countDigit = 0;
            int temp = num;
            int temp2 = num;
            while (num > 0)
            {
                int digit = num % 10;
                num = num / 10;
                countDigit++;
            }
            // Console.WriteLine(countDigit);
            num = temp;
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                int power = 1;
                for(int i=1;i<= countDigit; i++)
                {
                    power = power * digit;
                }
                sum = sum + power;
                num = num / 10;
                countDigit--;
            }
            if (temp2 == sum)
            {
                Console.WriteLine("Is Disarium Number:=" + temp2);
            }
            else
            {
                Console.WriteLine("Is  Not Disarium Number:=" + temp2);
            }
            

        }
    }
}
