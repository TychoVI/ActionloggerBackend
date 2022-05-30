using Actionlogger.Core.Util;

namespace Actionlogger.Core.Entity;

public class MeetingMember : BaseObject
{
    public Guid ProfileId { get; set; }
    public string Role { get; set; }
}