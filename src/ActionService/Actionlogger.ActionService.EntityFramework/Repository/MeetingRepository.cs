using Actionlogger.ActionService.Core.Interface;
using Actionlogger.ActionService.EntityFramework.Data;
using Actionlogger.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace Actionlogger.ActionService.EntityFramework.Repository;

public class MeetingRepository : IMeetingRepository
{
    private readonly AppDbContext _db;

    public MeetingRepository(AppDbContext db)
    {
        _db = db;
    }
    
    public async Task<IEnumerable<Meeting>> GetAll()
    {
        return await _db.Meetings.ToListAsync();
    }

    public async Task<Meeting> Create(Meeting meeting)
    {
        await _db.Meetings.AddAsync(meeting);
        await _db.SaveChangesAsync();
        return meeting;
    }
}