using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class Sum
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Enter the num1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the num2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int Sum = a + b;
            Console.WriteLine(Sum);
            Console.ReadLine();


        }
    }
}
