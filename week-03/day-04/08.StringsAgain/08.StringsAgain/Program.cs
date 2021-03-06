﻿using System;

namespace _07.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively a new string where all the 'x' chars have been removed.

            string myString = "x-flxboxs-x";
            Console.WriteLine(XtoY(myString));
            Console.ReadLine();

        }

        static string XtoY(string s)
        {
            if (s.Length == 0)
            {
                return s;
            }
            else if (s.Substring(0, 1) == "x")
            {
                return XtoY(s.Substring(1));
            }
            else
            {
                return s.Substring(0, 1) + XtoY(s.Substring(1));
            }

        }
    }
}
