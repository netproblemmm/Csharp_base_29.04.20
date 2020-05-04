using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1_task1_Survey
{
    class Lesson_1_task1_Survey
    {
        static void Main(string[] args)
        {
            // 1.Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).В результате вся информация выводится в одну строчку.
            // а) используя склеивание;
            // б) используя форматированный вывод;
            // в) *используя вывод со знаком $.
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваш рост в см");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваш вес в кг");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваши данные (склеивание):");
            Console.WriteLine("Фамилия и имя - " + surname + " " + name);
            Console.WriteLine("Возраст - " + age + ", рост - " + height + ", вес - " + weight);
            Console.WriteLine("");
            Console.WriteLine("Ваши данные (форматированный вывод):");
            Console.WriteLine(String.Format("Фамилия и имя - {0}", surname + " " + name));
            Console.WriteLine(String.Format("Возраст - {0}, рост - {1}, вес - {2}", age, height, weight));
            Console.WriteLine("");
            Console.WriteLine("Ваши данные (используя вывод со знаком $):");
            Console.WriteLine($"Фамилия и имя - {surname + " " + name}");
            Console.WriteLine($"Возраст - {age}, рост - {height}, вес - {weight}");
            Console.ReadLine();
        }
    }
}
