using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_task5_FIOcity
{
    class Lesson1_task5_FIOcity
    {
        static void Main(string[] args)
        {
            // а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            // б) Сделать задание, только вывод организуйте в центре экрана

            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите ваш город проживания");
            string city = Console.ReadLine();
            string str = $"{name} {surname} {city}";
            Console.SetCursorPosition((Console.WindowWidth - str.Length) / 2, Console.WindowHeight / 2);
            Console.WriteLine(str);

            // в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)
            Console.WriteLine("Введите координату x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату y");
            int y = Convert.ToInt32(Console.ReadLine());
            PrintInCenter(str, x, y);
            Console.ReadLine();
        }

        static void PrintInCenter(string ms, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
        }
    }
}
