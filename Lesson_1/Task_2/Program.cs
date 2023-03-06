/*
* Lesson 1 Task 2: get a number and add 10 to it
* Author: Stanislav Mykhailenko
* License: Unlicense
*/

int number;

Console.Write("Enter a number: ");

if (int.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine(number + 10);
}
else
{
    Console.WriteLine("Invalid data entereed.");
}
