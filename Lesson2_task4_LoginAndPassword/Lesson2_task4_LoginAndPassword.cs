// Ястребов Юрий
// 4. Реализовать метод проверки логина и пароля.На вход подается логин и пароль.
// На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
// Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
// программа пропускает его дальше или не пропускает.С помощью цикла do while ограничить ввод пароля тремя попытками.

class Lesson2_task4_LoginAndPassword
{
    static void Main()
    {
        View view = new View();
        PassCheck(view);
        view.Pause();
    }

    private static void PassCheck(View view)
    {
        int numbersOfTry = 1;
        do
        {
            view.Print($"Попытка {numbersOfTry}. Введите логин");
            string login = view.GetString();
            view.Print("Введите пароль");
            string password = view.GetString();
            if (IsAccessGranted(login, password))
            {
                view.Print("Доступ разрешен");
                return;
            }
            else
                numbersOfTry += 1;
        }
        while (numbersOfTry <= 3);

        view.Print("Доступ запрещен. Превышено к-во попыток");
        return;
    }

    private static bool IsAccessGranted(string login, string password)
    {
        if (login == "root" && password == "GeekBrains")
            return true;
        else
            return false;
    }
}
