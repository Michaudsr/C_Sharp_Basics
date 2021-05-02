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
        // {
        // //    2- Write a program which takes two numbers from the console and displays the maximum of the two. 
        //     Console.WriteLine("Type in two numbers to be compared and find the maximum");
        //     Console.WriteLine("First number: ");
        //     var firstNum = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine("Second Number: ");
        //     var secondNum = Convert.ToInt32(Console.ReadLine());

        //     if (firstNum == secondNum)
            
        //         Console.WriteLine("These numbers are the same");
            
        //     else 
        //         Console.WriteLine("Between {0} and {1}, the maximum is: {2}", firstNum, secondNum, getMaximum(firstNum, secondNum));
            
        //     static int getMaximum(int firstNum, int secondNum)
        //     {
        //         return (firstNum > secondNum) ? firstNum : secondNum;
        //     }

        // }
        
        // {
        //     // 3- Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.
        //     Console.WriteLine("Enter the width and height of an image to determine if it is landscape or portrait.");
        //     Console.ReadLine();
        //     Console.WriteLine("Width: ");
        //     var width = Convert.ToInt32(Console.ReadLine());
            
        //     Console.WriteLine("Height: ");
        //     var height = Convert.ToInt32(Console.ReadLine());
            
        //     if(width == height)
        //         Console.WriteLine("this image is a 1:1 ratio");
        //     if(width > height)
        //         Console.WriteLine("Landscape");
        //     if(width < height)
        //         Console.WriteLine("Portrait");
        // }
        {
            // 4- Your job is to write a program for a speed camera.
            // For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
            // Write a program that asks the user to enter the speed limit. 
            // Once set, the program asks for the speed of a car. 
            // If the user enters a value less than the speed limit, program should display Ok on the console.
            // If the value is above the speed limit, the program should calculate the number of demerit points. 
            // For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
            // If the number of demerit points is above 12, the program should display License Suspended.
            Console.WriteLine("Enter the speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the speed of the car: ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed > speedLimit)
            {
                var demeritPoints = 0;
                while(carSpeed > speedLimit)
                {
                    carSpeed -= 5;
                    demeritPoints ++;
                }
                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
            
            }
            else
            {
                Console.WriteLine("OK");
            }
        }
    }
}

