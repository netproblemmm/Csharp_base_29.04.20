// Ястребов Юрий
// 2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
// а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
// Использовать массив(или список) делегатов, в котором хранятся различные функции.
// б) * Переделать функцию Load, чтобы она возвращала массив считанных значений.
// Пусть она возвращает минимум через параметр(с использованием модификатора out). 

using System;
using System.IO;
class Lesson6_task2_FunctionMinimum
{
    public delegate double function(double x);

    static void Main()
    {
        function[] Func = {Func1, Func2};
        Console.WriteLine("Выберите функцию: 1 - функция x * x - 50 * x + 10, 2 - функция x * x - 100 * x");
        int functionNumber = Int32.Parse(Console.ReadLine());
        SaveFunc("data.bin", -100, 100, 0.5, Func[functionNumber - 1]);
        Console.WriteLine(Load("data.bin"));
        Console.ReadKey();
    }

    public static void SaveFunc(string fileName, double a, double b, double h, function Func)
    {
        FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
        BinaryWriter bw = new BinaryWriter(fs);
        double x = a;
        while (x <= b)
        {
            bw.Write(Func(x));
            x += h;
        }
        bw.Close();
        fs.Close();
    }
    public static double Load(string fileName)
    {
        FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
        BinaryReader bw = new BinaryReader(fs);
        double min = double.MaxValue;
        double d;
        for (int i = 0; i < fs.Length / sizeof(double); i++)
        {
            d = bw.ReadDouble();
            if (d < min) min = d;
        }
        bw.Close();
        fs.Close();
        return min;
    }

    public static double Func1(double x)
    {
        return x * x - 50 * x + 10;
    }

    public static double Func2(double x)
    {
        return x * x - 100 * x;
    }
}
