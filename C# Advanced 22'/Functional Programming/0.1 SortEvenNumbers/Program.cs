﻿using System;
using System.Linq;

namespace _0._1_SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(", ",
            Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(n => n % 2 == 0)
                .OrderBy(n => n)
                .ToArray()));
        }
    }
}
