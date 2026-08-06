using GameAnalyticsAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GameAnalyticsAPI.Data;

// Acts as the bridge between C# models and the database.
public class GameAnalyticsContext : DbContext
{
    public GameAnalyticsContext(DbContextOptions<GameAnalyticsContext> options)
        : base(options)
    {
    }

    public DbSet<GameEvent> GameEvents { get; set; } = null!; // Represents the GameEvents table in the database.
}