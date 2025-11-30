char[,] fields =
{
    { ' ', ' ', ' ' },
    { ' ', ' ', ' ' },
    { ' ', ' ', ' ' } 
};

showMenu();
int mode = int.Parse(Console.ReadLine());

showField();

bool isXTurn = true;
int n;

while (true) 
{
    if (mode == 1)
        humanMove();
    else if (mode == 2)
    {
        if (isXTurn)
            humanMove();
        else
        {
            Console.WriteLine("Хід компʼютера:");
            computerMove();
        }
    }

    if (checkWin())
        break;

    if (checkDraw())
        break;
}

if (checkDraw())
    Console.WriteLine("Нічия!");
else
{
    if (isXTurn) 
        Console.WriteLine("Виграв O!");
    if (!isXTurn) 
        Console.WriteLine("Виграв X!");
}

void computerMove()
{
    Random rand = new Random();

    while (true)
    {
        int move = rand.Next(1, 10);
        int moveIndex = move - 1;
        int moveRow = moveIndex / 3;
        int moveCol = moveIndex % 3;

        if (fields[moveRow, moveCol] == ' ')
        {
            fields[moveRow, moveCol] = 'O';
            break;
        }
        
    }

    isXTurn = true;

    showField();
}

void humanMove()
{
    if (isXTurn)
        Console.Write("\nХід гравця Х: ");
    else
        Console.Write("\nХід гравця O: ");

    n = int.Parse(Console.ReadLine());

    while (true)
    {
        if (n <= 0 || n > 9)
        {
            Console.WriteLine("Ви вийшли за межі діапазано");
            Console.Write("Введіть число від 1 до 9: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        else
            break;
    }

    int index = n - 1;
    int row = index / 3;
    int col = index % 3;

    if (fields[row, col] == ' ')
    {
        if (isXTurn)
            fields[row, col] = 'X';
        else if (!isXTurn)
            fields[row, col] = 'O';

        if (isXTurn)
            isXTurn = false;
        else
            isXTurn = true;

        showField();
    }
    else
        Console.WriteLine("\nКлітинка зайнята виберіть іншу");
}

void showMenu()
{
    Console.WriteLine("Оберіть режим гри:");
    Console.WriteLine("1 — Людина проти людини");
    Console.WriteLine("2 — Людина проти комп'ютера");
    Console.Write("Ваш вибір: ");
}

void showField()
{
    Console.WriteLine();
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(fields[i, j]);
            if (j != 2)
                Console.Write(" | ");
        }

        Console.WriteLine();

        if (i != 2)
            Console.WriteLine("----------");
    }
}

bool checkWin()
{
    if (fields[0, 0] != ' ' && fields[0, 0] == fields[0, 1] && fields[0, 1] == fields[0, 2])
        return true;

    if (fields[1, 0] != ' ' && fields[1, 0] == fields[1, 1] && fields[1, 1] == fields[1, 2])
        return true;

    if (fields[2, 0] != ' ' && fields[2, 0] == fields[2, 1] && fields[2, 1] == fields[2, 2])
        return true;

    if (fields[0, 0] != ' ' && fields[0, 0] == fields[1, 0] && fields[1, 0] == fields[2, 0])
        return true;

    if (fields[0, 1] != ' ' && fields[0, 1] == fields[1, 1] && fields[1, 1] == fields[2, 1])
        return true;

    if (fields[0, 2] != ' ' && fields[0, 2] == fields[1, 2] && fields[1, 2] == fields[2, 2])
        return true;

    if (fields[0, 0] != ' ' && fields[0, 0] == fields[1, 1] && fields[1, 1] == fields[2, 2])
        return true;

    if (fields[0, 2] != ' ' && fields[0, 2] == fields[1, 1] && fields[1, 1] == fields[2, 0])
        return true;

    return false;
}

bool checkDraw()
{
    for (int i = 0; i < 3; i++)
        for (int j = 0; j < 3; j++)
            if (fields[i, j] == ' ')
                return false;

    if (checkWin() == false)
        return true;
    else
        return false;
}