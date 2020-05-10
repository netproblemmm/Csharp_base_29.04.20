class Lesson2_task1_MinimumOf3Digits
    // Ястребов Юрий
    // 1. Написать метод, возвращающий минимальное из трех чисел.
{
    static void Main()
    {
        View view = new View();
        int minNumber = MinNumber(view);
        view.Print(minNumber);
        view.Pause();
    }

    private static int MinNumber(View view)
    {
        view.Print("Введите первое число");
        int firstNumber = view.GetInt();
        view.Print("Введите второе число");
        int secondNumber = view.GetInt();
        view.Print("Введите третье число");
        int thirdNumber = view.GetInt();

        int min = secondNumber < firstNumber ? secondNumber : firstNumber;
        min = thirdNumber < min ? thirdNumber : min;

        return min;
    }
}
