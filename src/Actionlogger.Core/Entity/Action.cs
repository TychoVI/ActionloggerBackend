using Actionlogger.Core.Util;

namespace Actionlogger.Core.Entity;

public class Action : BaseObject
{
    public string Task { get; set; }
    public string Notes { get; set; }
    public Guid ResponsibleProfileId { get; set; }
    public DateTime DueDateTime { get; set; }
}