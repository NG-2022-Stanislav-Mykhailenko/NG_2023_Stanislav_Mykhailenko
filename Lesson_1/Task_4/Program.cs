/*
* Lesson 1 Task 4: get two strings and concatenate them if the first one is longer, split the second one with the first character of the first string if the second one is longer, otherwise do nothing
* Author: Stanislav Mykhailenko
* License: Unlicense
*/

Console.Write("Enter string 1: ");

string? string1 = Console.ReadLine();

Console.Write("Enter string 2: ");

string? string2 = Console.ReadLine();

if (string1 == null || string2 == null)
{
}
else if (string1.Length > string2.Length)
	Console.WriteLine(string1 + string2);
else if (string1.Length < string2.Length)
{
	string[] split = string2.Split(string1[0]);
	foreach (string value in split)
		Console.WriteLine(value);
}
