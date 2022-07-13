/* Задание 6. Напишите программу с классом, в котором есть два поля: символьное и текстовое. 
* В классе должен быть перегруженный метод для присваивания значений полям.
* Если метод вызывается с символьным аргументом, то 
* соответствующее значение присваивается символьному полю.
* Если метод вызывается с текстовым аргументом, то 
* он определяет значение текстового поля.
* Методу аргументом также может передаваться символьный массив.
* Если массив состоит из одного элемента, то 
* он определяет значение символьного поля.
* Если в массиве больше одного элемента, из символов массива формируется 
* текстовая строка и присваивается значением текстовому полю. */
using System;
class MyClass
{
    public char symbol;
    public string text;
    public void SetValue(char s)
    {
        symbol = s;
    }
    public void SetValue(char s, string t)
    {
        symbol = s; text = t;
    }
    public void SetValue(char[] arr)
    {
        if (arr.Length == 1) symbol = arr[0];
        else text = String.Concat<char>(arr);
    }
    public void ShowValue()
    {
        Console.WriteLine("Символьное поле: {0}", symbol);
        Console.WriteLine("Текстовое поле: {0}", text);
    }
}
class ClassTaskSix
{
    static void Main()
    {
        MyClass A = new MyClass();
        char[] arr1 = { 'Д' };
        char[] arr2 = { 'Е', 'Ё', 'Ж' };

        Console.WriteLine("Метод с символьным аргументом");
        A.SetValue('А');
        A.ShowValue();

        Console.WriteLine("Метод с символьным и текстовым аргументами");
        A.SetValue('Б', "ВГ");
        A.ShowValue();

        Console.WriteLine("Метод с символьным массивом из одного элемента");
        A.SetValue(arr1);
        A.ShowValue();

        Console.WriteLine("Метод с символьным массивом");
        A.SetValue(arr2);
        A.ShowValue();
    }
}