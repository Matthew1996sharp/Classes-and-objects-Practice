/* Задание 2. Напишите программу с классом, у которого 
 * есть два символьных поля и метод.
 * Он не возвращает результат, и у него нет аргументов.
 * При вызове метод выводит в консольное окно все символы из кодовой таблицы,
 * которые находятся "между" символами, являющимися значениями полей объекта */
using System;
class MyClass
{
    public char FirstSymbol = 'A';
    public char LastSymbol = 'Z';
    public void ShowArray()
    {
        for (char i = FirstSymbol; i < LastSymbol; i++)
        {
            if (i == LastSymbol) Console.WriteLine(i);
            else Console.Write(i + "_");
        }
    }
}
class ClassTaskTwo
{
    static void Main()
    {
        MyClass obj = new MyClass();
        obj.ShowArray();
    }
}