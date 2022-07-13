/* Задание 6.4. Напишите программу с классом с целочисленным и символьным полем.
* В классе должны быть описаны версии конструктора с двумя аргументами
* (целое число и символ - определяют значения полей), и аргументом double.
* В последнем случае действительная часть аргумента определяет код символа
* (значение символьного поля), а дробная часть (с учётом десятых и сотых)
* определяет значение целочисленного поля. */
using System;
class MyClass
{
    public int number;
    public char symbol;
    public void ShowValues()
    {
        Console.WriteLine("Целочисленное поле: {0}", number);
        Console.WriteLine("Символьное поле: {0}", symbol);
    }
    public MyClass(int n, char s)
    {
        number = n; symbol = s;
    }
    public MyClass(double d)
    {
        number = (int)d;
        symbol = (char)((int)((d - number) * 100));
    }
}
class ClassTaskFour
{
    static void Main()
    {
        MyClass d = new MyClass(65.1267);
        d.ShowValues();
    }
}