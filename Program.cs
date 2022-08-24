using System;
 using enosis_solutions.ReverseString;
 using enosis_solutions.PalindromNumber;
using enosis_solutions.LoopPattern_1;
using enosis_solutions.LoopPattern_2;
using enosis_solutions.Fibonnachi;
using enosis_solutions.FirstNonRepeatChar;
using enosis_solutions.RepeatedElement;
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
            Console.WriteLine();

            /*
                Given a Range Print a Pattern using one loop 
                Input : 10 
                Output : 1 2 3 4 5 6 7 8 9 10 9 8 7 6 5 4 3 2 1
            */

            LoopPattern_1 lp1 = new LoopPattern_1();
            int range = 10;
            lp1.PrintPattern(range);
           

            /*
                Given a range Print a Pattern using one loop 
                Input : 10 
                Output : 10 9 8 7 6 5 4 3 2 1 2 3 4 5 6 7 8 9 10
            */
            LoopPattern_2 lp2 = new LoopPattern_2();
            lp2.PrintPattern(range);
             
             /*
                Print a Fibonnachi number using one loop 
                Input  : 100 
                Output : 0 1 1 2 3 5 8 ............. 
             */
            Fibonacchi fib = new Fibonacchi();
            fib.FibonacchiPattern(range);

            /*
                Print the non repeated First Charecter of a String :
                Input : BBCADAXXX
                Output : A
            */
            FirstNonRepeatChar Frc = new FirstNonRepeatChar();
            string text_2 = "ABCDABCDX";
            Frc.NonRepeatChar(text_2);

            /*
                Find Repeated Elements of the Array : 
                Input : [1 , 2 , 3 , 2 , 1]
                Output : [1,2]
            */
            RepeatedElement Re = new RepeatedElement();
            int [] array = new int[7]{1,2,3,1,2,3,4};
            Re.FindRepeatedElement(array);


        }
    }
}