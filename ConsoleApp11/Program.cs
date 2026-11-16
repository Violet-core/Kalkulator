using System;
using System.Globalization;

namespace DiscountCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Чтобы десятичный разделитель был точкой/запятой по локали
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            while (true)
            {
                Console.WriteLine("\n=== Калькулятор скидок ===");

                double price;
                while (true)
                {
                    Console.Write("Введите цену: ");
                    if (double.TryParse(Console.ReadLine(), out price) && price >= 0)
                        break;
                    Console.WriteLine("Ошибка! Введите неотрицательное число.");
                }

                double discount;
                while (true)
                {
                    Console.Write("Введите скидку в процентах (0–100): ");
                    if (double.TryParse(Console.ReadLine(), out discount)
                        && discount >= 0 && discount <= 100)
                        break;
                    Console.WriteLine("Ошибка! Скидка должна быть от 0 до 100.");
                }

                double result = price * (1 - discount / 100);
                double saved = price - result;

                Console.WriteLine($"\nЦена:          {price:F2}");
                Console.WriteLine($"Скидка:        {discount:F2}%");
                Console.WriteLine($"Экономия:      {saved:F2}");
                Console.WriteLine($"Цена со скидкой: {result:F2}");

                Console.Write("\nПосчитать ещё раз? (y/n): ");
                if (Console.ReadLine()?.Trim().ToLower() != "y")
                    break;
            }

            Console.WriteLine("До свидания!");
        }
    }
}