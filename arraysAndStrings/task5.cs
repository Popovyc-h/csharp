Console.Write("Enter text: ");
string text = Console.ReadLine();

text = text.Replace(" ", "");

int pos = 0;

for (int i = 0; i < text.Length; i++)
    if (text[i] == '+' || text[i] == '-')
    {
        pos = i;
        break;
    }

string firstNumber = text.Substring(0, pos);

int result = int.Parse(firstNumber);

for (int i = pos; i < text.Length; i++)
{
    if (text[i] == '+' || text[i] == '-')
    {
        char sign = text[i];
        int j = i + 1;
        string number = "";
        while (j < text.Length && char.IsDigit(text[j]))
        {
            number += text[j];
            j++;
        }

        int value = int.Parse(number);
        
        i = j - 1;

        if (sign == '+')
            result += value;
        else
            result -= value;
    }
}

Console.WriteLine(result);
