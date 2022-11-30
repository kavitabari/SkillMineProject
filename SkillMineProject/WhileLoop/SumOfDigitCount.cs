using System;

namespace SkillMineProject.WhileLoop
{
    class SumOfDigitCount
    {
        //write  code  count   the no  of  digit
        static void Main(string[] args)
        {
            int num,sum = 0;
            Console.WriteLine("Enter The No");
            num = int.Parse(Console.ReadLine());
            while(num!=0)  //(num > 0)
            {
                int digit = num % 10;
                 sum = sum + digit;
               // count ++;
                num = num / 10;
               
            }
          //  i++;
            Console.WriteLine("sum of  digit=:" + sum);
           
        }
    }
    class SumOfDigitCount1
    {
        static void Main(string[] args)
        {
            int num, count = 0;
            Console.WriteLine("Enter The No");
            num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                int digit = num % 10;
               /// sum = sum + digit;
                count++;
                num = num / 10;
            }
            Console.WriteLine("sum of  digit=:" + count);

        }
    }
}
