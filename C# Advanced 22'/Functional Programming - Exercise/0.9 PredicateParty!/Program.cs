﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._9_PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Party!")
                {
                    break;
                }
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string action = tokens[0];
                string filter = tokens[1];
                string value = tokens[2];

                if (action == "Remove")
                {
                    people.RemoveAll(GetPredicate(filter, value));
                }
                else
                {
                    List<string> peopleDouble = people.FindAll(GetPredicate(filter, value));
                    int index = people.FindIndex(GetPredicate(filter, value));

                    if (index >= 0)
                    {
                        people.InsertRange(index, peopleDouble);
                    }
                }
            }

            if (people.Any())
            {
                Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static Predicate<string> GetPredicate(string filter, string value)
        {
            switch (filter)
            {
                case "StartsWith":
                    return s => s.StartsWith(value);
                case "EndsWith":
                    return s => s.EndsWith(value);
                case "Length":
                    return s => s.Length == int.Parse(value);
                default:
                    return default(Predicate<string>);
            }
        }
    }
}
