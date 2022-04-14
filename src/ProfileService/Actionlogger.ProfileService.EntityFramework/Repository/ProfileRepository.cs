using Actionlogger.Core.Entity;
using Actionlogger.ProfileService.Core.Interface;
using Actionlogger.ProfileService.EntityFramework.Data;
using Microsoft.EntityFrameworkCore;

namespace Actionlogger.ProfileService.EntityFramework.Repository;

public class ProfileRepository : IProfileRepository
{
    private readonly AppDbContext _db;

    public ProfileRepository(AppDbContext db)
    {
        _db = db;
    }
    
    public async Task<IEnumerable<Profile>> GetAll()
    {
        return await _db.Profiles.ToListAsync();
    }
}