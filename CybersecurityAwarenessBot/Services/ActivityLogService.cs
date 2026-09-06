namespace CybersecurityAwarenessBot.Services;

public class ActivityLogService
{
    private readonly List<string> _entries = new();

    public void Add(string action)
    {
        _entries.Add($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {action}");

        // Keep a larger in-memory history, while the GUI displays only the latest 10.
        if (_entries.Count > 100)
            _entries.RemoveAt(0);
    }

    public List<string> GetRecent(int count = 10)
    {
        return _entries.AsEnumerable().Reverse().Take(count).ToList();
    }
}
