using System;

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
        return Int32.Parse(GetString());
    }

    public double GetDouble()
    {
        return Double.Parse(GetString().Replace('.', ','));
    }
}
