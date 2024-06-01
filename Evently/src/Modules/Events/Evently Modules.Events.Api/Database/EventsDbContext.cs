using Evently_Modules.Events.Api.Events;
using Microsoft.EntityFrameworkCore;

namespace Evently_Modules.Events.Api.Database;

public sealed class EventsDbContext(DbContextOptions<EventsDbContext> options) : DbContext(options) 
{
    internal DbSet<Event> Events { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema(Schemas.Events);
    }
}
