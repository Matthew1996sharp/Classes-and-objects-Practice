/* Задание 6.3. Напишите программу с классом с двумя целочисленными полями.
* В классе должны быть описаны конструкторы, позволяющие 
* создавать объекты без передачи аргументов, с передачей 
* одного аргумента и с передачей двух аргументов */
using System;
class MyClass
{
    public int number1;
    public int number2;
    public void ShowValues()
    {
        Console.WriteLine("Поля: {0} и {1}", number1, number2);
    }
    public MyClass()
    {
        number1 = 1; number2 = 2;
    }
    public MyClass(int a)
    {
        number1 = a; number2 = 4;
    }
    public MyClass(int a, int b)
    {
        number1 = a; number2 = b;
    }
}
class ClassTaskThree
{
    static void Main()
    {
        MyClass A = new MyClass();
        A.ShowValues();
        MyClass B = new MyClass(3);
        B.ShowValues();
        MyClass C = new MyClass(5, 6);
        C.ShowValues();
    }
}