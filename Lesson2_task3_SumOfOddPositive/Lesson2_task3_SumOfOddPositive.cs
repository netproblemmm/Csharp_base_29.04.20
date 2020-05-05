using System;

// Ястребов Юрий
// 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

class Lesson2_task3_SumOfOddPositive
{
    static void Main()
    {
        View view = new View();
        int digitQty = DigitQty(view);
        view.Print(digitQty);
        view.Pause();
    }

    private static int DigitQty(View view)
    {
        int number;
        int sum = 0;
        do
        {
            view.Print("Введите число");
            number = view.GetInt();
            if (IsDigitOdd(number) && IsDigitPositive(number))
                sum += number;
        }
        while(number != 0);

        return sum;
    }

    private static bool IsDigitOdd(int digit)
    {
        if (digit % 2 == 0)
            return true;
        else
            return false;
    }

    private static bool IsDigitPositive(int digit)
    {
        if (digit > 0)
            return true;
        else
            return false;
    }
}