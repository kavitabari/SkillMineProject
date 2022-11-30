using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.ConditionalOperator
{
    class LadderIfElseVowel
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter The Char");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a')
            {
                Console.WriteLine("vowel");
            }
           else if (ch == 'e')
            {
                Console.WriteLine("vowel");
            }
            else if (ch == 'i')
            {
                Console.WriteLine("vowel");
            }
            else if (ch == 'o')
            {
                Console.WriteLine("vowel");
            }
            else if (ch == 'u')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("Consonent");
            }
        }
    }
    //Vowel with LogicalOperator
    class LogicalOperatorVowal
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter The Char");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonent");
            }
        }
    }
}
