using System;
 using enosis_solutions.ReverseString;
 using enosis_solutions.PalindromNumber;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
                Given a Sentence you have to reverse all the cherecters.. !
                Input : This is a good Guy
                Output : sihT si a doog yuG
            */
            
            ReverseString revString = new ReverseString();
            string text = "Hi This is Md Ruhul Amin";
            Console.WriteLine(revString.reverseString(text));
            

            /*
                Given a Number you have to tell is it pallindrom or not 
                Input : 12321 
                Output : Palindrom 
            */
            
            PalindromNumber pnum = new PalindromNumber();
            int number_1 = 12321;
            pnum.checkPalindromOrNot(number_1);

        }
    }
}