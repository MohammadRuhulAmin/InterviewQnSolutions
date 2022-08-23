namespace enosis_solutions.ReverseString
{
    public class ReverseString
    {
        public  string reverseString(string text){
            string ansString = "";
            text +='\0';
            int startIndex = 0;
            for(int i = 0;i<text.Length;i++){
                 string tempString = "";
                if(text[i] == ' ' || text[i] == '\0'){
                   
                    for(int j = i;j>=startIndex;j--){
                        tempString +=text[j];
                    }
                    startIndex = i;
                    ansString += tempString;
                }
            }

            return ansString;
        }
    }
}