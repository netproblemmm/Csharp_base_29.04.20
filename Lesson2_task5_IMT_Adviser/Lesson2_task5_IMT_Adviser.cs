using System;

// Ястребов Юрий
// 5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает,
// нужно ли человеку похудеть, набрать вес или все в норме;
// б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
// задание с б) пока не успел

class Lesson2_task5_IMT_Adviser
{
    static void Main()
    {
        View view = new View();
        IMTCheck(view);
        view.Pause();
    }

    private static void IMTCheck(View view)
    {
        view.Print("Введите ваш рост в см");
        double height = Convert.ToDouble(view.GetString()) / 100d;
        view.Print("Введите ваш вес в кг");
        double weight = Convert.ToDouble(view.GetString());
        double imt = weight / Math.Pow(height, 2);
        view.Print($"Ваш индекс массы тела = {imt:.00}");
        view.Print(GetAdvise(imt));
        return;
    }

    private static string GetAdvise(double imt)
    {
        if (imt <= 16)
            return "Выраженный дефицит массы тела";
        else if (imt > 16 && imt < 18.5)
            return "Недостаточная масса тела";
        else if (imt >= 18.5 && imt < 25)
            return "Норма";
        else if (imt >= 25 && imt < 30)
            return "Избыточная масса тела (предожирение)";
        else if (imt >= 30 && imt < 35)
            return "Ожирение 1 степени";
        else if (imt >= 35 && imt < 40)
            return "Ожирение 2 степени";
        else if (imt >= 40)
            return "Ожирение 3 степени";
        else
            return "Ошибка расчета ИМТ";
    }
}
