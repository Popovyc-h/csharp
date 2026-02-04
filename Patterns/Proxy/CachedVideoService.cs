namespace Proxy;

// 3. Проксі (Кешування)
public class CachedVideoService : IVideoService
{
    private RealVideoService _realService;
    private Dictionary<int, string> _cache = new();

    public CachedVideoService(RealVideoService realService)
    {
        _realService = realService;
    }

    public string GetVideo(int videoId)
    {
        // TODO: Перевірити кеш. Якщо є - повернути.
        // Якщо немає - викликати _realService.GetVideo(), зберегти в кеш і повернути.
        if (_cache.ContainsKey(videoId))
            return _cache[videoId];
        
        string video = _realService.GetVideo(videoId);

        _cache[videoId] = video;

        return video;
    }
}
