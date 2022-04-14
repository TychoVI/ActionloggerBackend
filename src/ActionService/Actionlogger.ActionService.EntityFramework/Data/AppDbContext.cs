using Microsoft.EntityFrameworkCore;
using Action = Actionlogger.Core.Entity.Action;

namespace Actionlogger.ActionService.EntityFramework.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
            
    }
    
    public DbSet<Action> Actions { get; set; }
}