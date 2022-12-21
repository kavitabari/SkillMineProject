using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.SwappingNo
{
    class SwappingNoWithoutThirdVariable
    {
       static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enetr the first number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The second Number");
            num2 = int.Parse(Console.ReadLine());
            //swapping without using  third variable
            Console.WriteLine("Before Swapping First number is {0} andsecond number is {1}", num1, num2);
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            //num1 = num1 * num2; //multipication
            //num2 = num1 / num2;
            //num1 = num1 / num2;
            //after swapping
            Console.WriteLine("After Swapping First number is {0} andsecond number is {1}", num1, num2);
            Console.ReadLine();
        }
    }
}
