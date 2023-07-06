using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class Initializing_list
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(){ "abc", "xyz" };
            /*list.Add("xyz");
            list.Add("abc");*/
            foreach(string s in list)
            {
                Console.WriteLine(s);
                
            }
            Console.ReadLine();
        }
    }
}
