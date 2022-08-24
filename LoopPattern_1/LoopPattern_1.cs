namespace enosis_solutions.LoopPattern_1
{
    public class LoopPattern_1
    {

        public void PrintPattern(int highRange){
            int totalLength = highRange*2;
            for(int i = 1;i<totalLength;i++){
                if(i<=10)Console.Write(i+ " ");
                else{
                    Console.Write(totalLength-i+ " ");
                }
            }
             Console.WriteLine();

        }
    }
}