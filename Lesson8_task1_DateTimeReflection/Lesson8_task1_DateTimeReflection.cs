// Ястребов Юрий
// 1.	С помощью рефлексии выведите все свойства структуры DateTime

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

class Lesson8_task1_DateTimeReflection
{
    static void Main()
    {
        Type type = typeof(DateTime);
        //foreach (var property in type.GetProperties())
        //{
        //    Console.WriteLine(property.Name);
        //}
        for (int i = 0; i < type.GetProperties().Length; i++)
        {
            Console.WriteLine(type.GetProperties()[i]);
        }
        Console.ReadKey();

    }

    

}
