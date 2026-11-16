using System;
using System.Globalization;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            while (true)
            {
                Console.WriteLine("\n===== МЕНЮ =====");
                Console.WriteLine("1. Обычный калькулятор");
                Console.WriteLine("2. Расчёт скидки");     // ← новая строка
                Console.WriteLine("0. Выход");
                Console.Write("Выбор: ");

                switch (Console.ReadLine())
                {
                    case "1": BasicCalculator(); break;
                    case "2": DiscountCalculator(); break;   // ← новая строка
                    case "0": return;
                }
            }
        }

        static void BasicCalculator()
        {
            // ... ваш существующий код ...
        }

        // ↓↓↓ НОВАЯ ФУНКЦИЯ ↓↓↓
        static void DiscountCalculator()
        {
            Console.Write("Введите цену: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите скидку в процентах: ");
            double discount = Convert.ToDouble(Console.ReadLine());

            double result = price * (1 - discount / 100);
            Console.WriteLine($"Цена со скидкой: {result:F2}");
        }
    }
}