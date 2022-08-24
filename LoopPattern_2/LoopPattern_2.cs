namespace enosis_solutions.LoopPattern_2
{
    public class LoopPattern_2
    {
        // 10 9 8 7 6 5 4 3 2 1 2 3 4 5 6 7 8 9 10
        public void PrintPattern(int highrange){
            int totalRange = highrange*2;
            for(int i = 0;i<=totalRange;i++){
                int res = totalRange -((totalRange/2) + i);
                if(res == 0 || res == -1)continue;
                
                else if(res<0){
                    res*=-1;
                }
                Console.Write(res + " ");
               
            }            
            Console.WriteLine();
        }
    }
}