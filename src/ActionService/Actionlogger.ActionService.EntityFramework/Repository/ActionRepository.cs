using Actionlogger.ActionService.Core.Interface;
using Actionlogger.ActionService.EntityFramework.Data;
using Microsoft.EntityFrameworkCore;
using Action = Actionlogger.Core.Entity.Action;

namespace Actionlogger.ActionService.EntityFramework.Repository;

public class ActionRepository : IActionRepository
{
    private readonly AppDbContext _db;

    public ActionRepository(AppDbContext db)
    {
        _db = db;
    }
    
    public async Task<IEnumerable<Action>> GetAll()
    {
        return await _db.Actions.ToListAsync();
    }

    public async Task<Action> GetById(Guid id)
    {
        return await _db.Actions.FindAsync(id);
    }
}