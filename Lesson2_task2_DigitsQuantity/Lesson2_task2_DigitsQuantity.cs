using System;
// Ястребов Юрий
// 2. Написать метод подсчета количества цифр числа.

class Lesson2_task2_DigitsQuantity
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
        view.Print("Введите число");
        int number = view.GetInt();
        int qty = Convert.ToString(number).Length;

        return qty;
    }
}
