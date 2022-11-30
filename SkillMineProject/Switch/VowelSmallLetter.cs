using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMineProject.Switch
{
    class VowelSmallLetter
    {
        static void Main(string[]args)
        {
            char ch;
            Console.WriteLine("Enter The Char");
            ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'a': Console.WriteLine("Vowel:=" + ch);
                    break;
                case 'e':
                    Console.WriteLine("Vowel:=" + ch);
                    break;
                case 'i':
                    Console.WriteLine("Vowel:=" + ch);
                    break;
                case 'o':
                    Console.WriteLine("Vowel:=" + ch);
                    break;
                case 'u':
                    Console.WriteLine("Vowel:=" + ch);
                    break;
                default:Console.WriteLine("Consonent:=" + ch);
                    break;
            }

        }
    }
}
