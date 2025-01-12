﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._2_SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            HashSet<int> firstSet = new HashSet<int>();

            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < numbers[0]; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < numbers[1]; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }
            firstSet.IntersectWith(secondSet);

            Console.WriteLine(string.Join(" ", firstSet));
        }
    }
}
