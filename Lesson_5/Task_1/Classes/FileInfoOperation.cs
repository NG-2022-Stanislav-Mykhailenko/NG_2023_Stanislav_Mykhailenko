namespace Lesson5.Classes;

using Lesson5.Interfaces;

public class FileInfoOperation : IFileInfoOperation
{

    public static void GetFileInfo(string path)
    {
        var info = new FileInfo(path);
        
        Console.WriteLine($"Name: {info.Name}");
        Console.WriteLine($"Creation time: {info.CreationTime}");
        Console.WriteLine($"Length: {info.Length}");
    }
}
