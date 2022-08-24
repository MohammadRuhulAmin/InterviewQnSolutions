namespace enosis_solutions.PalindromNumber
{
    public class PalindromNumber
    {
        public  void checkPalindromOrNot(int number){
            int newNumb = 0;
            int storeNumb = number;
            while(number>0){
                int temp = number%10;
                number/=10;
                newNumb*=10;
                newNumb+=temp;
            }
            Console.WriteLine("The new numb is :"+newNumb);
            if(newNumb == storeNumb)Console.WriteLine("Palindrom Number");
            else Console.WriteLine("Not A Palindrom Number");
             Console.WriteLine();

        }
    }
}