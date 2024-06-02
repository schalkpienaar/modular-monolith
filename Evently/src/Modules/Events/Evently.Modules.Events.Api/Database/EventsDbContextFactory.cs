using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Evently.Modules.Events.Api.Database;

public class EventsDbContextFactory : IDesignTimeDbContextFactory<EventsDbContext>
{
    public EventsDbContext CreateDbContext(string[] args)
    {
        string connectionString = "Host=evently.database;Port=5432;Database=evently;Username=postgres;Password=postgres;Include Error Detail=true";
        
        var optionsBuilder = new DbContextOptionsBuilder<EventsDbContext>();
        optionsBuilder.UseNpgsql(connectionString);

        return new EventsDbContext(optionsBuilder.Options);
    }
}
