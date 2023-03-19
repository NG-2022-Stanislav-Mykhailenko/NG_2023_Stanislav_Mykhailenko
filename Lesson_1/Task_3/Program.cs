/*
* Lesson 1 Task 3: get a list of ten numbers and duplicate a number entered by user
* Author: Stanislav Mykhailenko
* License: Unlicense
*/

int duplicate;
List<int> numbers = new List<int>();

for (int i = 0; i < 10; i++)
{
    int newNumber;

    while (true)
    {
        Console.Write($"Enter number {i + 1}: ");
        if (int.TryParse(Console.ReadLine(), out newNumber))
            break;
    }

    numbers.Add(newNumber);
}

while (true)
{
    Console.Write($"Enter number to duplicate: ");
    if (int.TryParse(Console.ReadLine(), out duplicate))
        break;
}

for (int i = 0; i < numbers.Count; i++) {
    if (numbers[i] == duplicate)
    {
        numbers.Insert(i, duplicate);
        i++;
    }
}

Console.WriteLine(String.Join(", ", numbers));
