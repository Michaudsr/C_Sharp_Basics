using System;

namespace ConditionalsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 to 10");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsNumValid(number) ? "Valid" : "Invalid");
        }
        static bool IsNumValid(int number){
            return number >= 1 && number <= 10;
        }
    }
}
