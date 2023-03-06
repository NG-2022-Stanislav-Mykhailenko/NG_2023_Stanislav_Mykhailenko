/*
* Lesson 1 Task 3: get a list of ten numbers and duplicate a number entered by user
* Author: Stanislav Mykhailenko
* License: Unlicense
*/

int duplicate;
List<int> numbers = new List<int>();
string? userInput;

for (int i = 0; i < 10; i++)
{
	int newNumber;

	do
	{
		Console.Write(string.Format("Enter number {0}: ", i + 1));
		userInput = Console.ReadLine();
	} while (!int.TryParse(userInput, out newNumber));

	numbers.Add(newNumber);
}

do
{
	Console.Write("Enter a number to duplicate: ");
	userInput = Console.ReadLine();
} while (!int.TryParse(userInput, out duplicate));

for (int i = 0; i < numbers.Count; i++) {
	if (numbers[i] == duplicate)
	{
		numbers.Insert(i, duplicate);
		i++;
	}
}

Console.WriteLine(
	string.Join(", ",
		numbers.Select(number => number.ToString())
	)
);
