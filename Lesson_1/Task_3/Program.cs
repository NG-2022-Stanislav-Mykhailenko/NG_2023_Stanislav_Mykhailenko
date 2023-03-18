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

	do
	{
		Console.Write($"Enter number {i + 1}: ");
	} while (!int.TryParse(Console.ReadLine(), out newNumber));

	numbers.Add(newNumber);
}

do
{
	Console.Write("Enter a number to duplicate: ");
} while (!int.TryParse(Console.ReadLine(), out duplicate));

for (int i = 0; i < numbers.Count; i++) {
	if (numbers[i] == duplicate)
	{
		numbers.Insert(i, duplicate);
		i++;
	}
}

Console.WriteLine(String.Join(", ", numbers));
