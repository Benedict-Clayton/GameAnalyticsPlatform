using GameAnalyticsAPI.Data;
using GameAnalyticsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GameAnalyticsAPI.Services;

public class GameEventService // Basically a script that handles the creation and getting of events.
{
    private readonly GameAnalyticsContext context;

    // ASP.NET gives this service the database connection.
    public GameEventService(GameAnalyticsContext context)
    {
        this.context = context;
    }

    // Gets all events from SQL Server.
    public async Task<List<GameEvent>> GetEvents()
    {
        return await context.GameEvents.ToListAsync();
    }

    // Creates a new event and saves it to SQL Server.
    public async Task<GameEvent> CreateEvent(GameEvent gameEvent)
    {
        Console.WriteLine("Service received event!"); // Yay! A debug log! The savior of developers everywhere :)

        gameEvent.Timestamp = DateTime.UtcNow;

        // Adds the event to EF Core tracking.
        context.GameEvents.Add(gameEvent);

        // Actually sends INSERT command to SQL Server!
        await context.SaveChangesAsync();

        return gameEvent;
    }
}