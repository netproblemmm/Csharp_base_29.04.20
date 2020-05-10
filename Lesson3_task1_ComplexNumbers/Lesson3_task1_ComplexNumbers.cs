// 1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры;
// б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса;

using System;

struct ComplexStructure
{
    public double im;
    public double re;

    public ComplexStructure Plus(ComplexStructure x)
    {
        ComplexStructure y;
        y.im = im + x.im;
        y.re = re + x.re;
        return y;
    }

    public ComplexStructure Multi(ComplexStructure x)
    {
        ComplexStructure y;
        y.im = re * x.im + im * x.re;
        y.re = re * x.re - im * x.im;
        return y;
    }

    public ComplexStructure Minus(ComplexStructure x)
    {
        ComplexStructure y;
        y.im = im - x.im;
        y.re = re - x.re;
        return y;
    }

    public string ToString()
    {
        return re + "+" + im + "i";
    }
}

class ComplexClass
{
    public double im;
    public double re;

    public ComplexClass Plus(ComplexClass x2)
    {
        ComplexClass result = new ComplexClass();
        result.im = x2.im + im;
        result.re = x2.re + re;
        return result;
    }

    public ComplexClass Minus(ComplexClass x2)
    {
        ComplexClass result = new ComplexClass();
        result.im = x2.im - im;
        result.re = x2.re - re;
        return result;
    }

    public ComplexClass Multi(ComplexClass x2)
    {
        ComplexClass result = new ComplexClass();
        result.im = re * x2.im + im * x2.re;
        result.re = re * x2.re - im * x2.im;
        return result;
    }

    public string ToString()
    {
        return re + "+" + im + "i";
    }
}

class Lesson3_task1_ComplexNumbers
{
    static void Main()
    {
        ComplexStructure complex1;
        complex1.re = 1;
        complex1.im = 1;

        ComplexStructure complex2;
        complex2.re = 2;
        complex2.im = 2;

        Console.WriteLine("Сложение комплексных чисел в структуре: " + complex1.Plus(complex2).ToString());
        Console.WriteLine("Умножение комплексных чисел в структуре: " + complex1.Multi(complex2).ToString());
        Console.WriteLine("Вычитание комплексных чисел в структуре: " + complex1.Minus(complex2).ToString());

        ComplexClass complex3 = new ComplexClass();
        complex3.im = 4;
        complex3.re = 4;

        ComplexClass complex4 = new ComplexClass();
        complex4.im = 2;
        complex4.re = 2;

        Console.WriteLine("Сложение комплексных чисел в классе: " + complex3.Plus(complex4).ToString());
        Console.WriteLine("Умножение комплексных чисел в классе: " + complex3.Multi(complex4).ToString());
        Console.WriteLine("Вычитание комплексных чисел в классе: " + complex3.Minus(complex4).ToString());
        Console.ReadKey();
    }
}
