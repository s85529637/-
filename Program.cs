using ConsoleApp1;
using StackExchange.Redis;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Caching;
using Newtonsoft.Json;


class Program
{
    static async Task Main(string[] args)
    {
        //var a = new Subsets();
        //var b = a.subsets();
        //foreach (var permutation in b)
        //{
        //    Console.WriteLine(string.Join(", ", permutation));
        //}
        var a = new TaskAll();
        a.TaskWatiaAll();
      
    }


}





