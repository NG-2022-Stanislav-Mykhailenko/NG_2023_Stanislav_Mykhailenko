namespace Lesson5.Interfaces;

public interface ICopyDirectory
{
    public static abstract void Copy(string sourceDir, string destinationDir, bool recursive);
}
