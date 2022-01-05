using System;
using System.Collections.Generic;

namespace excercises
{
    public class Program
    {
        public static void Main()
        {
            
            // Console.WriteLine("Enter a few numbers separated by a hyphen ");
            // var input = Console.ReadLine();
            
            // var numbers = new List<int>();
            // foreach (var number in input.Split('-'))
            //     numbers.Add(Convert.ToInt32(number));                

            // numbers.Sort();

            // var isConsecutive = true;
            // for (var i = 1; i < numbers.Count; i++)
            // {
            //     if (numbers[i] != numbers[i - 1] + 1)
            //     {
            //         isConsecutive = false;
            //         break;
            //     }
            // }

            // var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            // Console.WriteLine(message);

            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                return;

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(numbers));

            var isUnique = new List<int>();
            var includesDuplicates = false;
            foreach (var number in numbers)
            {
                if (!isUnique.Contains(number))
                    isUnique.Add(number);
                else 
                {
                    includesDuplicates = true;
                    break;
                }

            }
            if (includesDuplicates)
                Console.WriteLine("Duplicate");

        }
    }
}
