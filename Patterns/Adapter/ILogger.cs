namespace Adapter;

// 1. Target (Цільовий інтерфейс)
public interface ILogger
{
    void Log(string message);
    void Error(string message);
}
