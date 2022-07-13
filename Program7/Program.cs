/* Задание 7. Напишите программу с классом, в котором есть закрытое 
* статическое целочисленное поле с начальным нулевым значением.
* В классе должен быть описан статический метод, при вызове которого
* отображается текущее значение статического поля, после чего 
* значение поля увеличивается на единицу */
using System;
class MyClass
{
    private static int number = 0;
    public static void ShowValue()
    {
        Console.WriteLine("Текущее значение целочисленного поля: {0}", number);
        number++;
    }
}
class ClassTaskSeven
{
    static void Main()
    {
        Console.Write("Введите количество оборотов: ");
        int count = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            MyClass.ShowValue();
        }
    }
}