/* Задание 9. напишите программу со статическим методом для вычисления:
* а) экспоненты exp(x) = summ(x^k/k!),
* б) синуса sin(x) = Summ((-1)^n*x^(2n+1)/(2n+1)!)
* в) косинуса cos(x) = Summ((-1)^n*x^(2n)/(2n)!),
* г) гиперболического синуса sh(x) = sum(x^(2n+1)/(2n+1)!),
* д) гиперболического косинуса ch(x) = sum(x^(2n)/(2n)!). */
using System;
class MyMath
{
    public const double pi = 3.141592;
    private static int N = 100;
    public static double Exp(double x)
    {
        double exp = 0, q = 1;
        for (int i = 0; i <= N; i++)
        {
            exp += q;
            q *= x / (i + 1);
        }
        return exp;
    }
    public static double Sin(double x)
    {
        double sin = 0, q = x;
        for (int i = 0; i <= N; i++)
        {
            sin += q;
            q *= (-1) * x * x / (2 * i + 2) / (2 * i + 3);
        }
        return sin;
    }
    public static double Cos(double x)
    {
        double cos = 0, q = 1;
        for (int i = 0; i <= N; i++)
        {
            cos += q;
            q *= (-1) * x * x / (2 * i + 1) / (2 * i + 2);
        }
        return cos;
    }
    public static double Sh(double x)
    {
        double sh = 0, q = x;
        for (int i = 0; i <= N; i++)
        {
            sh += q;
            q *= x * x / (2 * i + 2) / (2 * i + 3);
        }
        return sh;
    }
    public static double Ch(double x)
    {
        double ch = 0, q = 1;
        for (int i = 0; i <= N; i++)
        {
            ch += q;
            q *= x * x / (2 * i + 1) / (2 * i + 2);
        }
        return ch;
    }
}
class ClassTaskNine
{
    static void Main()
    {
        Console.Write("Введите значение для вычисления экспоненты: ");
        double z = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("exp({0}) = {1}", z, MyMath.Exp(z));
        Console.WriteLine("Контрольное значение: {0}", Math.Exp(z));

        Console.Write("Введите значение для вычисления " +
            "тригонометрических функций (в градусах): ");
        double x = Convert.ToDouble(Console.ReadLine()) * MyMath.pi / 180;

        Console.WriteLine("sin({0}) = {1}", x, MyMath.Sin(x));
        Console.WriteLine("Контрольное значение: {0}", Math.Sin(x));

        Console.WriteLine("cos({0}) = {1}", x, MyMath.Cos(x));
        Console.WriteLine("Контрольное значение: {0}", Math.Cos(x));

        Console.WriteLine("sh({0}) = {1}", x, MyMath.Sh(x));
        Console.WriteLine("Контрольное значение: {0}", Math.Sinh(x));

        Console.WriteLine("ch({0}) = {1}", x, MyMath.Ch(x));
        Console.WriteLine("Контрольное значение: {0}", Math.Cosh(x));
    }
}