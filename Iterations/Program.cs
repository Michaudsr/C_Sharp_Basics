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
        // {
        //     var name = "John Smith";

        //     // for (var i = 0; i < name.Length; i++)
        //     // {
        //     //     Console.WriteLine(name[i]);
        //     // }

        //     foreach (var character in name)
        //     {
        //         Console.WriteLine(character);
        //     }
        // }
        // {
        //     var numbers = new int[] {1, 2, 3, 4};

        //     foreach(var number in numbers)
        //     {
        //         Console.WriteLine(number);
        //     }

        // }
        // {
        // var i = 0;
        // while (i <= 10)
        // {
        //     if (i % 2 == 0)
        //     Console.WriteLine(i);

        //     i++;
        // }

        // }
        // {
        //     while (true)
        //     {
        //         Console.Write("Type your name: ");
        //         var input = Console.ReadLine();

        //         if (!string.IsNullOrWhiteSpace(input))
        //         {
        //             Console.WriteLine("@Echo: " + input);
        //             continue;
        //         }
        //         break;

        //     }
        // }
        {
            var random = new Random();
            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));
            var password = new string(buffer);
            Console.WriteLine(password);
            
        }
    }
}
