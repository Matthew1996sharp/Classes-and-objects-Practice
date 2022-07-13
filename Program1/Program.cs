/* Задание 1. Напишите программу с классом, в котором 
 * есть закрытое символьное поле и три открытых метода.
 * Один метод позволяет присвоить значение полю.
 * Второй метод при вызове возвращает код символа.
 * Третий метод позволяет вывести в консоль символ и его код */
using System;
class MyClass
{
    private char symbol; //закрытое символьное поле
    public void SetValue(char s)
    {
        symbol = s; //присваивание значения полю
    }
    public int GetCode(char s)
    {
        return (int)s; //возвращает код символа
    }
    public void ShowResult()
    {
        //отображение результата
        Console.WriteLine("Введённый символ: {0}", symbol);
        Console.WriteLine("Код введённого символа: {0}", GetCode(symbol));
    }
}
class ClassTaskOne
{
    static void Main()
    {
        Console.Write("Введите символ: ");
        char symbol = Convert.ToChar(Console.ReadLine());
        MyClass obj = new MyClass(); //создание объекта
        obj.SetValue(symbol); //присваивание значения полю
        obj.ShowResult(); //вывод результата
    }
}