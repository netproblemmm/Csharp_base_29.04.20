using System;
using System.IO;

public class MyArray
{
    int[] massive;
    int _elementsQty = 0;
    public MyArray(int elementsQty, int minRandomNumber, int maxRandomNumber)
    {
        _elementsQty = elementsQty;
        massive = new int[elementsQty];
        Random rnd = new Random();
        for (int i = 0; i < massive.Length; i++)
        {
            massive[i] = rnd.Next(-10000, 10001);
        }
    }

    public int Length
    {
        get
        {
            int Length = massive.Length;
            return Length;
        }
    }

    public int sumPairs()
    {
        int sumPairs = 0;
        for (int i = 0; i < massive.Length - 1; i++)
        {
            int score = 0;
            if (massive[i] % 3 == 0)
                score = 1;
            if (massive[i + 1] % 3 == 0)
                score += 1;
            if (score == 1)
                sumPairs += 1;
        }
        return sumPairs;
    }

    public string sumPairsToString(int sum)
    {
        String str = "";
        str = $"К-во пар элементов массива, в которых только одно число делится на 3: {sum}";
        return str;
    }

    public override string ToString()
    {
        String str = $"Массив из {_elementsQty} элементов:(";
        for (int i = 0; i < massive.Length; i++)
        {
            str = str + massive[i] + (i < massive.Length - 1 ? ", " : ")");
        }
        return str;
    }

    public void Clear()
    {
        MyArray[] massive = new MyArray[_elementsQty];
    }

    internal int[] LoadFromFile(string fileName)
    {
        try
        {
            StreamReader sr = new StreamReader(fileName);
            for (int i = 0; i < _elementsQty; i++)
            {
                massive[i] = int.Parse(sr.ReadLine());
            }
            sr.Close();
            return massive;
        }
        catch (System.IO.FileNotFoundException)
        {
            Console.WriteLine("Файл не найден!");
            return null;
        }
    }
}
