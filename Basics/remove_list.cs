using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class remove_list
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "abc", "def", "mno", "pqr" };
            list.RemoveAt(2);
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}