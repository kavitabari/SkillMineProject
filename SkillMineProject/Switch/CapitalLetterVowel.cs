using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Switch
{
    class CapitalLetterVowel
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter The Char");
            ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'A':
                    Console.WriteLine("Vowel:=" + ch);
                    break;
                case 'E':
                    Console.WriteLine("Vowel:=" + ch);
                    break;
                case 'I':
                    Console.WriteLine("Vowel:=" + ch);
                    break;
                case 'O':
                    Console.WriteLine("Vowel:=" + ch);
                    break;
                case 'U':
                    Console.WriteLine("Vowel:=" + ch);
                    break;
                default:
                    Console.WriteLine("Consonent:=" + ch);
                    break;
            }

        }
    }
}
