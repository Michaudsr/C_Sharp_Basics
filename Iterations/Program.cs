﻿using System;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        // {
        //    for (var i =1; i <= 10; i++)
        //    {
        //        if (i%2 == 0)
        //        {
        //            Console.WriteLine(i);
        //        }
        //    } 
        //    for (var i = 10; i >= 1; i--)
        //    {
        //        if (i%2 == 0)
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }
        // }
        {
            var name = "John Smith";

            // for (var i = 0; i < name.Length; i++)
            // {
            //     Console.WriteLine(name[i]);
            // }

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }
        }
    }
}