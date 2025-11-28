int shift;
string text = "";
string result = "";

if (args.Length < 2)
{
    Console.WriteLine("Not enough arguments");
    return;
}

shift = int.Parse(args[0]);
text = args[1];

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
