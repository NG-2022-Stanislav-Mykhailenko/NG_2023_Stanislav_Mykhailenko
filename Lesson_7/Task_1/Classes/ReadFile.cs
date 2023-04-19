namespace Lesson5.Classes;

using Lesson5.Interfaces;

public class ReadFile : IReadFile
{
    public static async Task ReadByPathAsync(string path)
    {
        if (File.Exists(path))
        {
            var data = await File.ReadAllTextAsync(path);
            Console.WriteLine(data);
        }
        else
            Console.WriteLine("No such file exists.");
    }
}
