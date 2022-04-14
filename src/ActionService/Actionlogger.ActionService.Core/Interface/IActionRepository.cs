using Action = Actionlogger.Core.Entity.Action;

namespace Actionlogger.ActionService.Core.Interface;

public interface IActionRepository
{
    public Task<IEnumerable<Action>> GetAll();
    public Task<Action> GetById(Guid id);
    public Task<Action> Create(Action action);
}