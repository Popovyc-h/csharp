
using System.Text;

string text;
Console.Write("Enter text: ");
text = Console.ReadLine();

bool makeUpper = true;

Console.WriteLine("Original text:");
Console.WriteLine(text);

StringBuilder sb = new StringBuilder();

for (int i = 0; i < text.Length; i++)
{
    if (text[i] == '.' || text[i] == '!' || text[i] == '?')
        makeUpper = true;

    if (makeUpper == true && char.IsLetter(text[i]))
    {
        sb.Append(char.ToUpper(text[i]));
        makeUpper = false;
    }
    else
        sb.Append(text[i]);
}

Console.WriteLine("\nEdited text:");
Console.WriteLine(sb.ToString());