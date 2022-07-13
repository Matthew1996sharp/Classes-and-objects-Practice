/* Задание 8. Напишите программу с классом, в котором есть статические методы,
* которым можно передавать произвольное количество целочисленных аргументов.
* Методы на основании переданных аргументов или массива позволяют вычислить:
* наибольшее и наименьшее значение, а также среднее значение из набора чисел */
using System;
class MyClass
{
    public static int GetMax(params int[] numbers)
    {
        int max = numbers[0];
        foreach (int item in numbers)
        {
            if (item > max) max = item;
        }
        return max;
    }
    public static int GetMin(params int[] numbers)
    {
        int min = numbers[0];
        foreach (int item in numbers)
        {
            if (item < min) min = item;
        }
        return min;
    }
    public static double GetAverage(params int[] numbers)
    {
        double average = 0;
        foreach (int item in numbers)
        {
            average += item;
        }
        return average / numbers.Length;
    }
}
class ClassTaskEight
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Console.WriteLine("Наибольшее значение: {0}", MyClass.GetMax(numbers));
        Console.WriteLine("Наименьшее значение: {0}", MyClass.GetMin(numbers));
        Console.WriteLine("Среднее значение: {0}", MyClass.GetAverage(numbers));
    }
}