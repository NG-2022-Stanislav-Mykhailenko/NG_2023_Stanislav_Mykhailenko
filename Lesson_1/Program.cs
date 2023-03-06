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
