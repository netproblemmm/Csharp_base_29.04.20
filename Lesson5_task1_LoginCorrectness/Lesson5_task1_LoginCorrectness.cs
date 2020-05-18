// Ястребов Юрий
// 1.	Создать программу, которая будет проверять корректность ввода логина.
// Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры,
// при этом цифра не может быть первой:
// а) без использования регулярных выражений;
// б) ** с использованием регулярных выражений.

using System;
using System.Text.RegularExpressions;

class Lesson5_task1_LoginCorrectness
{
    static void Main()
    {
        // а) без использования регулярных выражений;
        string login;
        bool loginCorrect = false;
        do
        {
            Console.WriteLine("Введите логин");
            login = Console.ReadLine();
            if (login.Length < 2 || login.Length > 10)
                Console.WriteLine("Логин должен состоять из 2-10 символов");
            else
            {
                if (Char.IsDigit(login[0]))
                    Console.WriteLine("Первый символ логина не должен быть цифрой");
                else
                {
                    // флаг наличия не латинских символов в логине
                    bool IsHaveBadSymbols = false;
                    for (int i = 0; i < login.Length; i++)
                    {
                        if (!char.IsLetterOrDigit(login[i]) || IsLatinSymbol(login[i]) == false)
                            IsHaveBadSymbols = true;
                    }
                    if (IsHaveBadSymbols)
                        Console.WriteLine("Логин должен состоять только из букв латинского алфавита или цифр");
                    else
                        loginCorrect = true;
                }

            }
        }
        while (!loginCorrect);

        Console.WriteLine("Логин верный!");

        // б) ** с использованием регулярных выражений
        Regex regex = new Regex("^[a-zA-Z][a-zA-Z0-9]{1,9}$");
        loginCorrect = false;

        do
        {
            Console.WriteLine("Введите логин (проверка с использованием регулярных выражений)");
            login = Console.ReadLine();
            if (regex.Match(login).Success)
            {
                Console.WriteLine("Логин верный!");
                loginCorrect = true;
            }
            else
            {
                Console.WriteLine("Логин должен состоять только из букв латинского алфавита или цифр");
            }
        }
        while (!loginCorrect);

        Console.ReadKey();

    }

    // проверка символа на принадлежность к латинице
    private static bool IsLatinSymbol(char symbol)
    {
        if ((symbol >= 'a' && symbol <= 'z') || (symbol >= 'A' && symbol <= 'Z'))
            return true;
        else
            return false;
    }
}