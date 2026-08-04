using GameAnalyticsAPI.Models;
namespace GameAnalyticsAPI.Services;

public class GameEventService // Basically a script that handles the creation and getting of events.
{
    private readonly List<GameEvent> events = new();

    public List<GameEvent> GetEvents()
    {
        return events;
    }

    public GameEvent CreateEvent(GameEvent gameEvent)
    {
        Console.WriteLine("Service received event!"); // Yay! A debug log! The savior of developers everywhere :)

        gameEvent.Id = events.Count + 1;
        gameEvent.Timestamp = DateTime.UtcNow;

        events.Add(gameEvent);

        return gameEvent;
    }
}