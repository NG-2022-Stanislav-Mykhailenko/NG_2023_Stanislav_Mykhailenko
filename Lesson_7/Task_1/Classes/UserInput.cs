namespace Lesson5.Classes;

using Lesson5.Interfaces;

public class UserInput : IUserInput
{
    public static string AskStringInput(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
                return input;
        }
    }
}
