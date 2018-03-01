﻿using System;

namespace _02.NumberAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a recursive function that takes one parameter: n and adds numbers from 1 to n.
            Console.WriteLine(NumberAdder(6));
            Console.ReadLine();
        }

        public static int NumberAdder(int n)
        {
            if (n == 0)
            {
                return n;
            }

            else
            {
                return n + NumberAdder(n - 1);
            }
        }
    }
}
