using System;
using enosis_solutions.ReverseString;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReverseString revString = new ReverseString();
            string text = "Hi This is Md Ruhul Amin";
            Console.WriteLine(revString.reverseString(text));
        }
    }
}