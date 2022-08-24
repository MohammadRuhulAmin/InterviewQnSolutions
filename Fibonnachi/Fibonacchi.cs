namespace enosis_solutions.Fibonnachi
{
    public class Fibonacchi
    {
        //0 1 1 2 3 5 8 13 21 ......
        public void FibonacchiPattern(int lastRange){
            int start = 0;int end = 1;
            for(int i = 0;i<=lastRange;i++){
                if(i <=1)Console.Write(i+ " ");
                int next = start+end;
                if(next<=lastRange){
                    Console.Write(next+ " ");
                    start = end;
                    end = next;
                }
                else break;
                
            }
            Console.WriteLine();
        }
    }
}