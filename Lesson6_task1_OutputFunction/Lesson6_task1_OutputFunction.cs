// Ястребов Юрий
// 1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
// Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).

using System;
using System.IO;

public delegate double Fun(double x, double a);
class Lesson6_task1_OutputFunction
{
    static void Main()
    {
        // Создаем новый делегат и передаем ссылку на него в метод Table
        Console.WriteLine("Таблица функции MyFunc: a * x^2");
        // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
        Table(new Fun(MyFunc), -2, 2, 3);

        Console.WriteLine("Таблица функции MyFunc: a * sin(x)");
        Table(new Fun(MyFunc2), -2, 2, 3);
        Console.ReadKey();
    }

    // Создаем метод, который принимает делегат
    // На практике этот метод сможет принимать любой метод
    // с такой же сигнатурой, как у делегата
    public static void Table(Fun F, double x, double b, double a)
    {
        Console.WriteLine("----- X ----- Y -----");
        while (x <= b)
        {
            Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, a));
            x += 1;
        }
        Console.WriteLine("---------------------");
    }
    // Создаем метод для передачи его в качестве параметра в Table
    public static double MyFunc(double x, double a)
    {
        return a * Math.Pow(x, 2);
    }
    public static double MyFunc2(double x, double a)
    {
        return a * Math.Sin(x);
    }
}