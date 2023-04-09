namespace Lesson5.Interfaces;

public interface IWorkWithFileSystem
{
    public static abstract void GetDirectoryFiles(string path);
    public static abstract string Cd(string name, string current);
}
