﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class RefandOut1
    {
        public static void ChangeRef(ref int numberRef)
        {
            numberRef = 5;
            Console.WriteLine("Inside the ChangeRef method the numberRef is " + numberRef);
        }
        public static void ChangeOut(out int numberOut)
        {
            numberOut = 20;
            Console.WriteLine("Inside the ChangeOut method the numberOut is " + numberOut);
        }

        static void Main(string[] args)
        {
            int numberRef = 15;

            Console.WriteLine($"Before calling the ChangeRef method the numberRef is {numberRef}");
            ChangeRef(ref numberRef);
            Console.WriteLine($"After calling the ChangeRef method the numberRef is {numberRef}");
            Console.WriteLine();
            int numberOut;
            Console.WriteLine("Before calling the ChangeOut method the numberOut is unassigned");
            ChangeOut(out numberOut);
            Console.WriteLine($"After calling the ChangeOut method the numberOut is {numberOut}");
            Console.ReadKey();
        }
    }
}
