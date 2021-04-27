using System;

namespace ConditionalsExercise
{
    class Program
    {
        static void Main()
        // {
        //     // 1- Write a program and ask the user to enter a number. 
        //     // The number should be between 1 to 10.
        //     // If the user enters a valid number, display "Valid" on the console. 
        //     // Otherwise, display "Invalid".
        //     //  (This logic is used a lot in applications where values entered into input boxes need to be validated.)
            
        //     Console.WriteLine("Enter a number between 1 to 10");
        //     var number = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine(IsNumValid(number) ? "Valid" : "Invalid");
        // }
        // static bool IsNumValid(int number){
        //     return number >= 1 && number <= 10;
        // }
        {
        //    2- Write a program which takes two numbers from the console and displays the maximum of the two. 
            Console.WriteLine("Type in two numbers to be compared and find the maximum");
            Console.WriteLine("First number: ");
            var firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Number: ");
            var secondNum = Convert.ToInt32(Console.ReadLine());

            if (firstNum == secondNum)
            
                Console.WriteLine("These numbers are the same");
            
            else 
                Console.WriteLine("Between {0} and {1}, the maximum is: {2}", firstNum, secondNum, getMaximum(firstNum, secondNum));
            
            static int getMaximum(int firstNum, int secondNum)
            {
                return (firstNum > secondNum) ? firstNum : secondNum;
            }

        }
    }
}
