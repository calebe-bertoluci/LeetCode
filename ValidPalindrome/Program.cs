using System.Text.RegularExpressions;

Console.WriteLine("*** VALID PALINDROME ***\n");
Console.Write("Type a word: ");
string word = Console.ReadLine().Replace(" ","");

Regex rgxRemover = new Regex("[^a-zA-Z0-9 -]");
word = rgxRemover.Replace(word, "");

string[] wordInArray = new string[word.Length];
string[] invertedWordInArray = new string[word.Length];
int i = 0 , j = 0;
string wordFixed="", invertedWordFixed="";

foreach (char c in word)
{
    wordInArray[i] = c.ToString();
    wordFixed += wordInArray[i];
    i++;
}

for (i = word.Length-1; i >= 0; i--)
{
    invertedWordInArray[j] = wordInArray[i];
    invertedWordFixed += invertedWordInArray[j];
    j++;
}

wordFixed = wordFixed.ToUpper();
invertedWordFixed = invertedWordFixed.ToUpper();

Console.WriteLine($"\nTyped: {wordFixed} \nInverted: {invertedWordFixed}\n");

if (wordFixed.Equals(invertedWordFixed))
    Console.WriteLine("Yes, it's a palindrome.");
else Console.WriteLine("No, it isn't a palindrome.");