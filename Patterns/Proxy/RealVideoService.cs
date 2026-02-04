namespace Proxy;

// 2. Реальний сервіс (важкий ресурс)
public class RealVideoService : IVideoService
{
    public string GetVideo(int videoId)
    {
        Console.WriteLine($"[RealService] Завантаження відео {videoId} з сервера...");
        Thread.Sleep(2000); // Імітація затримки
        return $"Video Content #{videoId}";
    }
}
