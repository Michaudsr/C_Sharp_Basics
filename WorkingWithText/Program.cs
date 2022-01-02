using System;
using System.Collections.Generic;

namespace WorkingWithText
{
    class Program
    {
        public static void Main(string[] args)
    {
            // var fullName = "Steven Michaud ";
            // Console.WriteLine("Trim: '{0}'", fullName.Trim());
            // Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());
            
            // var index = fullName.IndexOf(' ');
            // var firstName = fullName.Substring(0, index);
            // var lastName = fullName.Substring(index + 1);
            // Console.WriteLine("FirstName: " + firstName);
            // Console.WriteLine("LastName: " + lastName);

            // var names = fullName.Split(' ');
            // Console.WriteLine("FirstName: " + names[0]);
            // Console.WriteLine("FirstName: " + names[1]);

            // Console.WriteLine(fullName.Replace("Steven", "stevo"));

            // if(String.IsNullOrWhiteSpace(" "))
            //     Console.WriteLine("Invalid");

            // var str = "25";
            // var age = Convert.ToByte(str);
            // Console.WriteLine(age);

            // float price = 29.95f;
            // Console.WriteLine(price.ToString("C0"));
    //         var sentence = "This is going to be a really really really really long text.";
    //         const int maxLength = 20;
    //         if(sentence.Length < maxLength)
    //             Console.WriteLine(sentence);
    //         else
    //         {
    //             var words = sentence.Split(' ');
    //             var totalCharacters = 0;
    //             var summaryWords = new List<string>();

    //             foreach(var word in words)
    //             {
    //                 summaryWords.Add(word);
    //                 totalCharacters += word.Length + 1;
    //                 if(totalCharacters > maxLength)
    //                     break;

    //             }
    //             var summary = String.Join(" ", summaryWords) + "...";
    //             Console.WriteLine(summary);
    //         }
    //     }
    // }
        var sentence="This is going to be a really really really really really long text ";
        var summary = StringUtility.SummerizeText(sentence, 25);
        Console.WriteLine(summary);
     
   
} 
} 
}
