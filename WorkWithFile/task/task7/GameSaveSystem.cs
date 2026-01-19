namespace ConsoleApp1;

internal class GameSaveSystem
{
    public static void SaveGame(Player p)
    {
        using StreamWriter writer = new StreamWriter("savegame.dat");
        
        writer.WriteLine($"Name:{p.Name}|Level:{p.Level}|Health:{p.Health}");

        Console.WriteLine("Game saved successfully");
    }

    public static Player LoadGame()
    {
        using StreamReader reader = new StreamReader("savegame.dat");

        var data = reader.ReadToEnd();
        var parts = data.Split('|');

        var name = parts[0].Split(':')[1];
        int level = int.Parse(parts[1].Split(':')[1]);
        int health = int.Parse(parts[2].Split(':')[1]);

        var player = new Player(name, level, health);

        return player;
    }
}
