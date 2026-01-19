namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        var player1 = new Player("Gnom", 10, 100);
        var player2 = new Player("Boss", 21, 69);

        player1.Print();

        GameSaveSystem.SaveGame(player2);

        var pl = GameSaveSystem.LoadGame();

        pl.Print();
    }
}
