/* Задание 5. Напишите программу с классом, у которого есть закрытое 
* целочисленное поле. Значение полю присваивается с помощью открытого метода. 
* Методу аргументом может присваиваться целое число, 
* а также метод может вызываться без аргументов. 
* Если метод вызывается без аргументов, то поле получает нулевое значение. 
* Если метод вызывается целочисленным аргументом, 
* то это значение присваивается полю. 
* Однако, если переданное аргументом методу значение превышает 100, 
* то значением полю присваивается 100. 
* Предусмотрите в классе конструктор, который работает по 
* тому же принципу, что и метод для присваивания значения полю. 
* Также в классе должен быть метод, позволяющий проверить значение поля */
using System;
class MyClass
{
    private int number;
    public MyClass(int n)
    {
        if (n < 100) number = 100;
        else number = n;
    }
    public MyClass()
    {
        number = 0;
    }
    public void SetValue(int n)
    {
        if (n < 100) number = 100;
        else number = n;
    }
    public void SetValue()
    {
        number = 0;
    }
    public void ShowValue()
    {
        Console.WriteLine("Целочисленное поле: {0}", number);
    }
}
class ClassTaskFive
{
    static void Main()
    {
        Console.Write("Введите целое число больше 100: ");
        int more = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите целое число меньше 100: ");
        int less = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Первый объект без аргументов");
        MyClass A = new MyClass();
        Console.WriteLine("Метод без аргументов");
        Console.WriteLine("Если больше 100");
        A.SetValue();
        A.ShowValue();
        Console.WriteLine("Если меньше 100");
        A.SetValue();
        A.ShowValue();
        Console.WriteLine();
        Console.WriteLine("Метод с аргументами");
        Console.WriteLine("Если больше 100");
        A.SetValue(more);
        A.ShowValue();
        Console.WriteLine("Если меньше 100");
        A.SetValue(less);
        A.ShowValue();
        Console.WriteLine();
        Console.WriteLine("Второй объект с аргументом");
        MyClass B = new MyClass(0);
        Console.WriteLine("Метод без аргументов");
        Console.WriteLine("Если больше 100");
        B.SetValue();
        B.ShowValue();
        Console.WriteLine("Если меньше 100");
        B.SetValue();
        B.ShowValue();
        Console.WriteLine();
        Console.WriteLine("Метод с аргументами");
        Console.WriteLine("Если больше 100");
        B.SetValue(more);
        B.ShowValue();
        Console.WriteLine("Если меньше 100");
        B.SetValue(less);
        B.ShowValue();
        Console.WriteLine();
    }
}