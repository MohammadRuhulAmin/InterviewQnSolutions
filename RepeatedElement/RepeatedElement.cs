namespace enosis_solutions.RepeatedElement
{
    public class RepeatedElement
    {
        public void FindRepeatedElement(int [] array){
           int length = array.Length;
           List<int> repeatedElem = new List<int>();
           bool [] visited = new bool[length];
           Array.Fill(visited,false);
           for(int i = 0;i<length;i++){
                if(!visited[i]){
                    bool found = false;
                    int elem = array[i];
                    for(int j = 0;j<length;j++){
                        if(i!=j){
                            if(elem == array[j]){
                                visited[j] = true;
                                found = true;
                            }
                        }
                    }
                    if(found)repeatedElem.Add(elem);        
                }
           }
           foreach(var elem in repeatedElem){
            Console.Write(elem + " ");
           }
            Console.WriteLine();
        }
    }
}