char[,] fields =
{
    { ' ', ' ', ' ' },
    { ' ', ' ', ' ' },
    { ' ', ' ', ' ' } 
};

showMenu();
int mode = int.Parse(Console.ReadLine());

showField();

bool isXTurn = new Random().Next(2) == 0;
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
            Console.WriteLine("Computer's turn:");
            computerMove();
        }
    }

    if (checkWin())
        break;

    if (checkDraw())
        break;
}

if (checkDraw())
    Console.WriteLine("It's a draw!");
else
{
    if (isXTurn) 
        Console.WriteLine("\nO wins!");
    if (!isXTurn) 
        Console.WriteLine("\nX wins!");
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
        Console.Write("\nPlayer X's move: ");
    else
        Console.Write("\nPlayer O's move: ");

    n = int.Parse(Console.ReadLine());

    while (true)
    {
        if (n <= 0 || n > 9)
        {
            Console.WriteLine("You went out of bounds");
            Console.Write("Enter a number from 1 to 9: ");
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
        Console.WriteLine("\nCell is already taken, choose another");
}

void showMenu()
{
    Console.WriteLine("Choose game mode:");
    Console.WriteLine("1 — Human vs Human");
    Console.WriteLine("2 — Human vs Computer");
    Console.Write("Your choice: ");
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
