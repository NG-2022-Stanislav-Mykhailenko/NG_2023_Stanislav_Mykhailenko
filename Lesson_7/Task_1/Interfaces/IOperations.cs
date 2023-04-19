namespace Lesson5.Interfaces;

public interface IOperations
{
    static void GetFileInfo(string path) => throw new NotImplementedException();
    static Task CopyAsync(string source, string destination, bool keepSource=true) => throw new NotImplementedException();
    static Task DeleteAsync(string path) => throw new NotImplementedException();
}
