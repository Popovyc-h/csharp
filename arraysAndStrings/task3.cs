Console.Write("Enter the offset: ");
int shift = int.Parse(Console.ReadLine());

Console.Write("Enter the text to encrypt: ");
string text = Console.ReadLine();

string result = "";
string decrypted = "";

Console.WriteLine("\nEncrypted text");
for (int i = 0; i < text.Length; i++)
{
    char ch = text[i];
    
    if (char.IsUpper(ch))
    {
        int index = ch - 'A';

        int newIndex = index + shift;
        newIndex %= 26;

        char encrypted = (char)('A' + newIndex);
        
        result += encrypted;
    }
    else if (char.IsLower(ch))
    {
        int index = ch - 'a';
        
        int newIndex = index + shift;
        newIndex %= 26;
        
        char encrypted = (char)('a' + newIndex);
     
        result += encrypted;
    }
}
Console.WriteLine(result);
Console.WriteLine("\nDecoded text");
for (int i = 0; i < result.Length; i++)
{
    char ch = result[i];
    if (char.IsUpper(ch))
    {
        int index = ch - 'A';

        int newIndex = index - shift;
        newIndex %= 26;

        if (newIndex < 0)
            newIndex += 26;

        char encrypted = (char)('A' + newIndex);

        decrypted += encrypted;
    }
    else if (char.IsLower(ch))
    {
    int index = ch - 'a';

    int newIndex = index - shift;
    newIndex %= 26;

    if (newIndex < 0)
        newIndex += 26;

    char encrypted = (char)('a' + newIndex);

    decrypted += encrypted;
    }
}

Console.WriteLine(decrypted);
