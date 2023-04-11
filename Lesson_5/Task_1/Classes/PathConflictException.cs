namespace Lesson5.Classes;

[Serializable]
public class PathConflictException : Exception
{
    public PathConflictException ()
    {
    }

    public PathConflictException (string message)
        : base(message)
    {
    }

    public PathConflictException (string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
