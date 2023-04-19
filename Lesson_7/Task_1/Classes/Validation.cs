namespace Lesson5.Classes;

using Lesson5.Interfaces;

public class Validation : IValidation
{
    public static string Check(string source, string destination)
    {
        if (File.Exists(destination))
            throw new PathConflictException();

        if (Directory.Exists(destination))
            destination = Path.Combine(destination, Path.GetFileName(source));

        if (File.Exists(destination) || Directory.Exists(destination))
            throw new PathConflictException();

        return destination;
    }
}
