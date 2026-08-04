namespace GameAnalyticsAPI.Models;

public class GameEvent // This defines the data. In Unity terms, this is basically a Scriptable Object.
{
    public int Id { get; set; }

    public string EventName { get; set; } = string.Empty;

    public string? EventData { get; set; }

    public DateTime Timestamp { get; set; }
}