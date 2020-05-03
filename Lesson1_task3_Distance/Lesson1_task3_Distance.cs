using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_task3_Distance
{
    class Lesson1_task3_Distance
    {
        static void Main(string[] args)
        {
            // а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2
            // по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
            // Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
            // б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;

            Console.WriteLine("Введите координату x первой точки");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату y первой точки");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату x второй точки");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату y второй точки");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            // не нашел такого формата .2f, работает с форматом f2;
            Console.WriteLine($"Расстояние между точками = {distance:f2}");
            Console.ReadLine();
        }
    }
}
