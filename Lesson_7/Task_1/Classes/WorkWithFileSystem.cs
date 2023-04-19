namespace Lesson5.Classes;

using Lesson5.Interfaces;

public class WorkWithFileSystem : IWorkWithFileSystem
{
    public static async Task GetDirectoryFilesAsync(string path)
    {
        var current = new DirectoryInfo(path);
        var dirs = await Task.Run(() => Directory.GetDirectories(current.FullName));
        var files = await Task.Run(() => Directory.GetFiles(current.FullName));
        
        foreach (var dir in dirs)
        {
            Console.WriteLine(dir.Split('\\').Last() + "/");
        }
        foreach (var file in files)
        {
            Console.WriteLine(file.Split('\\').Last());
        }
    }

    public static string Cd(string name, string current)
    {
        if (name == "..")
        {
            var info = new DirectoryInfo(current);

            var parent = info.Parent;

            return parent is not null ? parent.FullName : current;
        }
        
        var dir = Path.Combine(current, name);
        
        if (Directory.Exists(dir))
        {
            return dir;
        }

        return current;
    }
}
