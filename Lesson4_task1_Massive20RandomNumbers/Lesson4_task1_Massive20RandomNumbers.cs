// Ястребов Юрий
// 1.	Дан целочисленный  массив из 20 элементов.Элементы массива  могут принимать  целые значения  от –10 000 до 10 000 включительно.
// Заполнить случайными числами.Написать программу, позволяющую найти и вывести количество пар элементов массива,
// в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива.
// Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 

using System;

class Lesson4_task1_Massive20RandomNumbers
    {
        static void Main()
        {

        int elementsQty = 20;
        int[] array20 = new int[elementsQty];
        Random rnd = new Random();
        String str = $"Массив из {elementsQty} элементов:(";

        for (int i = 0; i < array20.Length; i++)
        {
            array20[i] = rnd.Next(-10000, 10001);
            str = str + array20[i] + (i < array20.Length - 1 ? ", " : ")");
        }

        Console.WriteLine(str);

        int sumPairs = 0;
        for (int i = 0; i < array20.Length - 1; i++)
        {
            int score = 0;
            if (array20[i] % 3 == 0)
                score = 1;
            if (array20[i + 1] % 3 == 0)
                score += 1;
            if (score == 1)
                sumPairs += 1;
        }

        Console.WriteLine($"К-во пар элементов массива, в которых только одно число делится на 3: {sumPairs}");
        Console.ReadKey();
        }
    }