showSquare(5, '#');

void showSquare(int length, char symbol)
{
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++)
            Console.Write(symbol);
        Console.WriteLine();
    }
}
