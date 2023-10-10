//Substring methodunu custom yazmaq.

//string Array =  "Salam necesiz " ;
//Console.WriteLine(  Array.Substring(6));

string Word=Console.ReadLine();
string index=Console.ReadLine();
int Index = int .Parse(index);
string length = Console.ReadLine();
int Length=int .Parse(length);

char[] smt = { };
Substring(Word,Index,Length);

void Substring(string word, int i, int length)
{
        char[] Letters = word.ToCharArray();
      for (int j = i; j <= length; j++)
    {
        smt = smt.Append(Letters[j]).ToArray();  
    }
    Console.WriteLine(smt);
}