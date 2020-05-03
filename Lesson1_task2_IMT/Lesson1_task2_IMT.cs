using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_task2_IMT
{
    class Lesson1_task2_IMT
    {
        static void Main(string[] args)
        {
            // 2.Ввести вес и рост человека.
            // Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах
            Console.WriteLine("Введите ваш рост в см");
            double height = (Convert.ToDouble(Console.ReadLine())) / 100d;
            Console.WriteLine("Введите ваш вес в кг");
            double weight = Convert.ToDouble(Console.ReadLine());
            double imt = weight / Math.Pow(height, 2);
            Console.WriteLine($"Ваш индекс массы тела = {imt:.00}");
            Console.ReadLine();
        }
    }
}
