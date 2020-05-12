using System;
using System.IO;

public class View
{
    public void Print(object value, bool isNewLine = true)
    {
        if (isNewLine)
        {
            Console.WriteLine(value);
        }
        else
        {
            Console.Write(value);
        }
    }
    
    public void Pause()
    {
        Console.ReadKey();
    }

    public string GetString()
    {
        return Console.ReadLine();
    }

    public int GetInt()
    {
        int num = 0;
        bool error = false;
        do
        {
            try
            {
                error = false;
                num = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Ошибка! Не удается преобразовать строку в число!");
                error = true;
            }
        }
        while(error == true);
        
        return num;
    }

    public double GetDouble()
    {
        return Double.Parse(GetString().Replace('.', ','));
    }
}
