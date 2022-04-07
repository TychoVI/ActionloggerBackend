using Actionlogger.Core.Entity;

namespace Actionlogger.ProfileService.Core.Interface;

public interface IProfileRepository
{
    public Task<IEnumerable<Profile>> GetAll();
}