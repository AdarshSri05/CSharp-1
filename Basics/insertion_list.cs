using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class insertion_list
    {
        static void Main(String[] args)
        {
            List<string> list = new List<string>() { "xyz", "abc", "mno" };
            list.Insert(1, "pqr");
            foreach (var item in list)
            {
                Console.WriteLine(item);    
            }
            Console.ReadLine();
        }
    }
}
