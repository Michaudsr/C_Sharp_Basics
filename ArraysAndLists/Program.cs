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
        // {
        //     var numbers = new List<int>() {1, 2, 3, 4};
        //     numbers.Add(1);
        //     numbers.AddRange(new int[3] {5, 6, 7});
        //     foreach(var number in numbers)
        //         Console.WriteLine(number);

        //     Console.WriteLine();
        //     Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
        //     Console.WriteLine("Index of 1: " + numbers.LastIndexOf(1));

        //     Console.WriteLine("Count: " + numbers.Count);

        //     for (var i = 0; i < numbers.Count; i++)
        //     {
        //         if ( numbers[i] == 1)
        //             numbers.Remove(numbers[i]);
        //     }
           
        //     foreach(var number in numbers)
        //         Console.WriteLine(number);
               
        //     numbers.Clear();
        //     Console.WriteLine("Count: " + numbers.Count);

        // }
        // 1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
            // If no one likes your post, it doesn't display anything.
            // If only one person likes your post, it displays: [Friend's Name] likes your post.
            // If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
            // If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
            // Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
        // {
        //     var likes = new List<string>();
            
        //     while(true)
        //     {
        //         Console.WriteLine("Type a name (or hit ENTER to quit): ");
        //         var input = Console.ReadLine();
        //         if (String.IsNullOrWhiteSpace(input))
        //             break;
        //         likes.Add(input);
        //     }
        //     if(likes.Count > 2)
        //         Console.WriteLine("{0}, {1} and {2} others like your post", likes[0], likes[1], likes.Count -2);
        //     else if (likes.Count == 2)
        //         Console.WriteLine("{0} and {1} like your post", likes[0], likes[1]);
        //     else if(likes.Count == 1)
        //         Console.WriteLine("{0} and {1} like your post", likes[0], likes[1]);
        //     else Console.WriteLine();
        // }
        // 2- Write a program and ask the user to enter their name. 
        // Use an array to reverse the name and then store the result in a new string. 
        // Display the reversed name on the console.
        {
            Console.WriteLine("What's your name? ");
            var name = Console.ReadLine();

            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            var reversed = new string(array);
            Console.WriteLine("Reversed name: " + reversed);

        }
    }
}
