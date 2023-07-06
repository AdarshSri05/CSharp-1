using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class edit_List
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "abc", "def", "pqr", "mno" };
            list[1] = "xyz";
            foreach (var item in list) { 
            Console.WriteLine(item);    
            }
            Console.ReadLine();

        }
    }
}
