namespace StringAnalysisWithDelegates;

internal class Program
{
    public static int CountVowels(string text)
    {
        char[] vowels = { 'a', 'A', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u' };
        int count = 0;
        
        foreach (var t in text)
            if (vowels.Contains(t))
                count++;

        return count;
    }

    public static int CountConsonants(string text)
    {
        char[] vowels = { 'a', 'A', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u' };
        int count = 0;

        foreach (var t in text)
            if (char.IsLetter(t) && !vowels.Contains(t))
                count++;

        return count;
    }

    public static int CalculateStringLength(string text)
    {

        return text.Length;
    }

    static void Main(string[] args)
    {
        string text = "Hello World";

        Func<string, int> del = CalculateStringLength;

        Console.WriteLine($"Length: {del(text)}");

        del += CountVowels;

        Console.WriteLine($"Vowels: {del(text)}");

        del += CountConsonants;

        Console.WriteLine($"Consonants: {del(text)}");
    }
}
