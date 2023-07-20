using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class ifAndElse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string sentence = Console.ReadLine();
            Console.WriteLine("Choose your color: y for yellow, m for magenta, o for Other");
            char color = Convert.ToChar(Console.ReadLine());
            if (color == 'y')
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(sentence);
            }
            else if (color == 'm')
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(sentence);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(sentence);
            }
            Console.ReadKey();
        }
    }
}
