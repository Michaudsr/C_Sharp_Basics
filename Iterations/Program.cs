using System;

namespace Iterations
{
    class Program
    {
        public static void Main()
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
        // {
        //     var random = new Random();
        //     const int passwordLength = 10;
        //     var buffer = new char[passwordLength];
        //     for (var i = 0; i < passwordLength; i++)
        //         buffer[i] = (char)('a' + random.Next(0, 26));
        //     var password = new string(buffer);
        //     Console.WriteLine(password);
            
        // }
        // 1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
        // Display the count on the console
        // {
            
        //     var count = 0;
        //     for (var i = 1; i <= 100; i++)
        //         if (i % 3 == 0) count++;
        //         Console.WriteLine(count);

        //     return count;
            
            
        // }
        // 2- Write a program and continuously ask the user to enter a number or "ok" to exit. 
        // Calculate the sum of all the previously entered numbers and display it on the console.
        // {
        //     var sum = 0;
        //     while(true)
        //     {
        //         Console.WriteLine("Enter a number: ");
        //         var input = Console.ReadLine();
        //         if(input == "ok")
        //             break;
        //         var number = Convert.ToInt32(input);
        //         sum += number;
                    

        //     }
        //     Console.WriteLine("Sum of all the numbers is: {0}", sum);
            
        // }
        // 3- Write a program and ask the user to enter a number. 
        // Compute the factorial of the number and print it on the console. 
        // For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
        {
            Console.WriteLine("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;
            for (var i = 1; i <= number; i++)
                factorial *= i;
            Console.WriteLine("{0}! = {1}", number, factorial);
        }
    }
}
