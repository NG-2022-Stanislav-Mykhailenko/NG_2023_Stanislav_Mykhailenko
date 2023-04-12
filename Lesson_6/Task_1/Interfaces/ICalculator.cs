namespace Lesson6.Interfaces;

public interface ICalculator
{
    event CalculationPerformedEventHandler? CalculationPerformed;

    void Calculate(string expression);

    delegate void CalculationPerformedEventHandler(double result);
}
