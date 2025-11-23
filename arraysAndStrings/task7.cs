using System.Text.RegularExpressions;

string text = "To be, or not to be, that is the question, Whether 'tis nobler in the mind to suffer The slings and arrows of outrageous fortune, Or to take arms against a sea of troubles, And by opposing end them? To die: to sleep; No more; and by a sleep to say we end The heart-ache and the thousand natural shocks That flesh is heir to, 'tis a consummation Devoutly to be wish'd. To die, to sleep";
int count = 0;

string[] badWords = { "die" };

string[] words = Regex.Split(text, @"\W+");

foreach (var word in words)
{
    string lowerWord = word.ToLower();

    if (badWords.Contains(lowerWord))
    {
        int length = lowerWord.Length;
        string symbol = new string('*', length);
        text = text.Replace(word, symbol);
        count++;
    }
}

Console.WriteLine(text);
Console.WriteLine($"\nCount: {count}");