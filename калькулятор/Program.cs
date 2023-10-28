using System;
abstract class Calculator
{
    public abstract double Calculate(double num1, double num2);
}

class Addition : Calculator
{
    public override double Calculate(double num1, double num2)
    {
        return num1 + num2;
    }
}
class Subtraction : Calculator
{
    public override double Calculate(double num1, double num2)
    {
        return num1 - num2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Выберите операцию +, -");
        char operation = Convert.ToChar(Console.ReadLine());

        Calculator calculator;

        switch (operation)
        {
            case '+':
                calculator = new Addition();
                break;
            case '-':
                calculator = new Subtraction();
                break;
            default:
                throw new InvalidOperationException("Некорректная операция");
        }

        double result = calculator.Calculate(num1, num2);

        Console.WriteLine("Результат: " + result);
    }

}
