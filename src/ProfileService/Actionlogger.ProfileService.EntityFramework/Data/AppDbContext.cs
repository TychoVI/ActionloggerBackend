using Actionlogger.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace Actionlogger.ProfileService.EntityFramework.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
            
    }
    
    public DbSet<Profile> Profiles { get; set; }
}