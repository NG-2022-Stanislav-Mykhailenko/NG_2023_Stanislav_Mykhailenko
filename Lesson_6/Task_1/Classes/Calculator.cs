namespace Lesson6.Classes;

using Lesson6.Interfaces;

public class Calculator : ICalculator
{
    public event ICalculator.CalculationPerformedEventHandler? CalculationPerformed;

    public void Calculate(string expression)
    {
        string[] tokens = expression.Split(' ');

        double firstNumber;
        double secondNumber;
        string inputOperation;
        double result;
        Operation operation = new Operation();
        Operation.Do oper;

        try
        {
            firstNumber = double.Parse(tokens[0]);
            secondNumber = double.Parse(tokens[2]);
            inputOperation = tokens[1];
        }
        catch
        {
            Console.WriteLine("Invalid format.");
            return;
        }

        switch (inputOperation)
        {
            case "+":
                oper = operation.Add;
                break;
            case "-":
                oper = operation.Subtract;
                break;
            case "*":
                oper = operation.Multiply;
                break;
            case "/":
                oper = operation.Divide;
                break;
            default:
                Console.WriteLine("Invalid operation.");
                return;
        }

        result = oper.Invoke(firstNumber, secondNumber);

        // raise the event
        CalculationPerformed?.Invoke(result);
    }

    public delegate void CalculationPerformedEventHandler(double result);
}
