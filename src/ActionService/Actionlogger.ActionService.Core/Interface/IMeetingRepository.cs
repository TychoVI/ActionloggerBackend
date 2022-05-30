using Actionlogger.Core.Entity;

namespace Actionlogger.ActionService.Core.Interface;

public interface IMeetingRepository
{
    public Task<IEnumerable<Meeting>> GetAll();
    public Task<Meeting> Create(Meeting meeting);
}