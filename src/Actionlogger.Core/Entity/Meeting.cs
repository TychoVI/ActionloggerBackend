using Actionlogger.Core.Util;

namespace Actionlogger.Core.Entity;

public class Meeting : BaseObject
{
    public string Name { get; set; }
    public Guid Creator { get; set; }
    public IEnumerable<MeetingMember> Members { get; set; }
    public IEnumerable<Action> Actions { get; set; }
}