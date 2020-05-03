using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_task4_ChangeVariables
{
    class Lesson1_task4_ChangeVariables
    {
        static void Main(string[] args)
        {
            // 4.Написать программу обмена значениями двух переменных.
            // а) с использованием третьей переменной;

            int a = 50;
            int b = 100;
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("С использованием третьей переменной:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            // б) *без использования третьей переменной.
            a = 50;
            b = 100;
            b += a;     // a = 50, b = 150
            a = b - a;  // a = 100, b = 150
            b = b - a;  // a = 100, b = 50
            Console.WriteLine("Без использования третьей переменной:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.ReadLine();
        }
    }
}
