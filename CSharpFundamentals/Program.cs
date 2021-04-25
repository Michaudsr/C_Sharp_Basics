using System;
// using CSharpFundamentals.Math;


namespace CSharpFundamentals
{
      class Program
    {
        static void Main(string[] args)
        {
            // var numbers = new int[3];
            // numbers[0] = 1;
            // Console.WriteLine(numbers[0]);
            // Console.WriteLine(numbers[1]);
            // Console.WriteLine(numbers[2]);

            // var flags = new bool[3];
            // flags[0] = true;
            // Console.WriteLine(flags[0]);
            // Console.WriteLine(flags[1]);
            // Console.WriteLine(flags[2]);

            // var names = new string[3] {"Jack", "John", "Mary"};
            // Console.WriteLine(names[0]);
            // Console.WriteLine(names[1]);
            // Console.WriteLine(names[2]);
            
            var firstName = "Mosh";
            var lastName = "Hamedani";

            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            var names = new string[3] {"John", "Jack", "Mary"};
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

        }
    }
}
