using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalOperator
{
    class TochekEitherDigitCharSpecialChar
    {
        //eithe chr digit special char  using nested if else
        static void Main(string[]args)
        {
            char ch;
            Console.WriteLine("Enter the Char");
            ch = Convert.ToChar(Console.ReadLine());
            if((ch<='A'&& ch <='Z')|| (ch <= 'a' && ch <= 'z'))
            {
                Console.WriteLine("Alphabet");
            }
            else if (ch <= 0 && ch <= 9)
            {
                Console.WriteLine("Digit");
            }
            else
            {
                Console.WriteLine("Special  Character");
            }
        }
    }
}
