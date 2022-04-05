namespace Actionlogger.Core.Util;

public class BaseObject
{
    public Guid Id { get; set; }
    public DateTime DateTimeCreated { get; }

    public BaseObject()
    {
        DateTimeCreated = DateTime.Now;
    }
}