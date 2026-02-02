using System;
{
    static void Main()
    {
        Console.WriteLine("Введите ваше имя:");
        string имя = Console.ReadLine();

        Console.WriteLine($"Привет, {имя}!");

        Console.WriteLine($"Сегодня {DateTime.Now.DayOfWeek}");

        bool продолжить = true;

        while (продолжить)
        {
            Console.WriteLine("Хотите продолжить? (y/n)");
            string ответ = Console.ReadLine();

            if (ответ.ToLower() == "n")
            {
                продолжить = false;
            }
            else if (ответ.ToLower() == "y")
            {
                Console.WriteLine("Продолжение…");
                Console.WriteLine($"Привет, {имя}!");
                Console.WriteLine($"Сегодня {DateTime.Now.DayOfWeek}");
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите y или n");
            }
        }
    }
}