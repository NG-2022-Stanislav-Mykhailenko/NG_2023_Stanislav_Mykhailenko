namespace Lesson6.Classes;

using Lesson6.Interfaces;

public class Operation : IOperation
{
    public double Add(double firstSummand, double secondSummand) => firstSummand + secondSummand;
    public double Subtract(double minuend, double subtrahend) => minuend - subtrahend;
    public double Multiply(double firstFactor, double secondFactor) => firstFactor * secondFactor;
    public double Divide(double dividend, double divisor) => dividend / divisor;
    public delegate double Do(double firstNumber, double secondNumber);
}
