namespace enosis_solutions.FirstNonRepeatChar
{
    public class FirstNonRepeatChar
    {
        public void NonRepeatChar(string str){
            int length = str.Length;
            bool [] repeated = new bool[length]; 
            Array.Fill(repeated,true);
            for(int i = 0;i<length;i++){
                char x = str[i];
                for(int j = 0;j<length;j++){
                    if(i!=j){
                        if(x == str[j]){
                            repeated[j] = false;
                        }
                       
                    }
                }
            }
            for(int i = 0;i<length;i++){
                if(repeated[i] == true){
                    Console.WriteLine("The First Non Repeated Char is : " + str[i]);
                    break;
                }
            }
        }
    }
}