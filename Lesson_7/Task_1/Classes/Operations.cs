namespace Lesson5.Classes;

using Lesson5.Interfaces;

public class Operations : IOperations
{

    public static void GetFileInfo(string path)
    {
        var info = new FileInfo(path);
        
        Console.WriteLine($"Name: {info.Name}");
        Console.WriteLine($"Creation time: {info.CreationTime}");
        Console.WriteLine($"Length: {info.Length}");
    }

    public static async Task CopyAsync(string source, string destination, bool keepSource=true)
    {
        try
        {
            destination = Validation.Check(source, destination);
        }
        catch (PathConflictException)
        {
            Console.WriteLine("Conflict.");
            return;
        }

        bool exists = await Task.Run(() => Directory.Exists(source) || File.Exists(source));

        if (exists)
            if (keepSource)
            {
                if (Directory.Exists(source))
                    await Task.Run(() => CopyDirectory.Copy(source, destination, true));
                else if (File.Exists(source))
                    await Task.Run(() => File.Copy(source, destination));
            }
            else
            {
                await Task.Run(() => Directory.Move(source, destination));
            }
        else
            Console.WriteLine("Not found.");
    }

    public static async Task DeleteAsync(string path)
    {
        if (Directory.Exists(path))
            await Task.Run(() => Directory.Delete(path, true));
        else if (File.Exists(path))
            await Task.Run(() => File.Delete(path));
        else
            Console.WriteLine("Not found.");
    }
}