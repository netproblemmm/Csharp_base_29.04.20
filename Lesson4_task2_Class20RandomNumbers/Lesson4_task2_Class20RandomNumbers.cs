// Ястребов Юрий
// 2. Реализуйте задачу 1 в виде статического класса StaticClass;
// а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
// б) * Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
// в)** Добавьте обработку ситуации отсутствия файла на диске.

using System;

class Lesson4_task2_Class20RandomNumbers
{
    static void Main()
    {

        int elementsQty = 20;
        MyArray arr = new MyArray(elementsQty, -10000, 10000);
        Console.WriteLine(arr.ToString());

        int sum = arr.sumPairs();
        Console.WriteLine(arr.sumPairsToString(sum));
        Console.ReadKey();

        arr = new MyArray(elementsQty, 0,0);
        arr.LoadFromFile("..\\..\\MyArrayTextFile.txt");
        Console.WriteLine(arr.ToString());
        Console.ReadKey();
    }
}
