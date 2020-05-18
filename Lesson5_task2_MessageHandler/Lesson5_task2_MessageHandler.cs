// Ястребов Юрий
// 2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
// а) Вывести только те слова сообщения, которые содержат не более n букв.
// б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
// в) Найти самое длинное слово сообщения.
// г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
// д) *** Создать метод, который производит частотный анализ текста.
//      В качестве параметра в него передается массив слов и текст,
//      в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
//      Здесь требуется использовать класс Dictionary.

using System;

class Lesson5_task2_MessageHandler
{
    static void Main()
    {
        string mess = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
        Console.WriteLine(mess);
        Console.WriteLine("а) Введите ограничение к-ва букв");
        int symbolsLimit = Int32.Parse(Console.ReadLine());

        Console.WriteLine($"Из фразы удалены все слова с длиной более {symbolsLimit} букв:");
        string mess2 = Message.SymbolsLimit(mess, symbolsLimit);
        Console.WriteLine(mess2);
        Console.ReadKey();

        string endLetter;
        do
        {
            Console.WriteLine("б) Введите букву. Будут удалены все слова, которые оканчиваются на эту букву");
            endLetter = (Console.ReadLine());
            if (endLetter.Length > 1)
                Console.WriteLine("Нужно ввести 1 букву");
        }
        while (endLetter.Length > 1);
        
        Console.WriteLine($"Из фразы удалены все слова, которые оканчиваются на букву {endLetter}:");
        string mess3 = Message.DeleteWordsWithLastLetter(mess, endLetter);
        Console.WriteLine(mess3);
        Console.ReadKey();

        Console.WriteLine($"Самое длинное слово во фразе: {Message.MostLongWord(mess)}");
        Console.ReadKey();

        Console.WriteLine($"Самые длинные слова во фразе, используя StringBuilder:");
        string mess4 = Message.MostLongWordsStringBuilder(mess);
        Console.WriteLine(mess4);
        Console.ReadKey();
    }
}
