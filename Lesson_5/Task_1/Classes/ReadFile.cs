namespace Lesson5.Classes;

using Lesson5.Interfaces;

public class ReadFile : IReadFile
{
    public static void ReadByPath(string path)
    {
        var text = File.ReadLines(path);

        foreach (var str in text)
        {
            Console.WriteLine(str);   
        }
    }
}
