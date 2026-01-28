namespace Singleton;

public class Government
{
    private static Government _instance;

    private Government() { }

    public static Government GetInstance()
    {
        if (_instance == null)
            _instance = new Government();

        return _instance;
    }
}
