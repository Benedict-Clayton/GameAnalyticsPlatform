using GameAnalyticsAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GameAnalyticsAPI.Data;

public class GameAnalyticsContext : DbContext
{
    public GameAnalyticsContext(DbContextOptions<GameAnalyticsContext> options)
        : base(options)
    {
    }

    public DbSet<GameEvent> GameEvents { get; set; }
}