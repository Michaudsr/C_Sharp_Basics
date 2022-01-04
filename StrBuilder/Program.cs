using System;
using System.Text;

namespace StrBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder("Hello World");
            
            builder.AppendLine();
            builder.Append("Header");
            builder.Append('-', 10);
            builder.Append('-', 10);
            // Console.WriteLine(builder);

            builder.Replace('-', '+');
            // Console.WriteLine(builder);

            builder.Remove(0, 10);   
            // Console.WriteLine(builder);

            builder.Insert(0, new string('-', 10));
            Console.WriteLine(builder);

            Console.WriteLine("First Char: " + builder[0]);


        }
    }
}
