/*
* Lesson 6 Task 1: calculator using delegates, events and lambdas
* Author: Stanislav Mykhailenko
* License: Unlicense
*/

using Lesson6.Classes;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            // subscribe to the event
            calc.CalculationPerformed += result => Console.WriteLine($"Result: {result}");

            while (true)
            {
                Console.Write("Enter expression (e.g. 2 + 2) or exit: ");
                string? expression = Console.ReadLine();

                if (expression == null)
                    continue;

                if (expression == "exit")
                    break;

                calc.Calculate(expression);
            }
        }
    }
}
