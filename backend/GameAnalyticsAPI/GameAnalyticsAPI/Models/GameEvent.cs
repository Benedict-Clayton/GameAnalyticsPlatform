namespace GameAnalyticsAPI.Models;

public class GameEvent
{
    public int Id { get; set; }

    public string EventName { get; set; } = string.Empty;

    public string? EventData { get; set; }

    public DateTime Timestamp { get; set; }
}