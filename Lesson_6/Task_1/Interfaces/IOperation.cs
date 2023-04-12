namespace Lesson6.Interfaces;

public interface IOperation
{
    double Add(double firstSummand, double secondSummand);
    double Subtract(double minuend, double subtrahend);
    double Multiply(double firstFactor, double secondFactor);
    double Divide(double dividend, double divisor);
    delegate double Do(double x, double y);
}
