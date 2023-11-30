string [] StrArray = new string[5] {"567", "35", "fxgh", "rot", "nub"}; 
string [] CreatFiltArray(string [] stringArray) 
{
  int n = 0;
  for (int i = 0;i<stringArray.Length;i++) 
  {
    if(stringArray[i].Length <=3)    
    n++;
  }
  string [] rez = new string [n];  
  int j = 0;
  for (int i = 0;i<stringArray.Length;i++) 
  {
    if(stringArray[i].Length <=3)  
    {
        rez[j] = stringArray[i];  
        j++;
    }
  }
  return rez;  
}
void printArr(string [] stringArray)  
{
    Console.Write("[");
    for (int i = 0;i<stringArray.Length-1;i++) 
    {
        Console.Write($"\"{stringArray[i]}\",");
    }
    Console.Write($"\"{stringArray[stringArray.Length-1]}\"");
    Console.WriteLine("]");
}   
printArr(CreatFiltArray(StrArray));