// 2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
// Требуется подсчитать сумму всех нечетных положительных чисел.Сами числа и сумму вывести на экран, используя tryParse;
// б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
// При возникновении ошибки вывести сообщение.Напишите соответствующую функцию;

using System;

namespace Lesson3_task2_SumOfOddPositiveWithTryParse
{
    class Lesson3_task2_SumOfOddPositiveWithTryParse
    {
        static void Main()
        {
            View view = new View();
            int digitQty = DigitQty(view);
            view.Print($"Сумма чисел = {digitQty}");
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
            while (number != 0);

            return sum;
        }

        private static bool IsDigitOdd(int digit)
        {
            if (digit % 2 != 0)
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
}
