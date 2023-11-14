using ConsoleApp1;
using StackExchange.Redis;
using System;
using System.Collections;
using System.Collections.Generic;

namespace GuessTheNumber
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var a = new Permutations();
            var b = a.permutations();
            foreach (var permutation in b)
            {
                Console.WriteLine(string.Join(", ", permutation));
            }
        }
    }
}

