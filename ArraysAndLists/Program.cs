using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        // {
        //     var numbers = new[] {3, 7, 9, 2, 14, 6 };

        //     // Length
        //     Console.WriteLine("Length: " + numbers.Length);

        //     // IndexOf()
        //     var index = Array.IndexOf(numbers, 9);
        //     Console.WriteLine("Index of 9: " + index);

        //     // Clear()
        //     Array.Clear(numbers, 0, 2);

        //     foreach(var n in numbers)
        //         Console.WriteLine(n);

        //     // Copy()
        //     int[] another = new int[3];
        //     Array.Copy(numbers, another, 3);

        //     Console.WriteLine("Effect of Copy()");
        //     foreach(var n in another)
        //         Console.WriteLine(n);

        //     // Sort()
        //     Array.Sort(numbers);
        //     Console.WriteLine("Effect of Sort()");
        //     foreach(var n in numbers)
        //         Console.WriteLine(n);

        //     //Reverse 
        //     Array.Reverse(numbers);

        //     Console.WriteLine("Effect of Reverse()");
        //     foreach(var n in numbers)
        //         Console.WriteLine(n);


        // }
        {
            var numbers = new List<int>() {1, 2, 3, 4};
            numbers.Add(1);
            numbers.AddRange(new int[3] {5, 6, 7});
            foreach(var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine();
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Index of 1: " + numbers.LastIndexOf(1));

            Console.WriteLine("Count: " + numbers.Count);

            for (var i = 0; i < numbers.Count; i++)
            {
                if ( numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }
           
            foreach(var number in numbers)
                Console.WriteLine(number);
               
            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);

        }
    }
}
