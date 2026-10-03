using System;
namespace ConsoleApp1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Введите температуру воздуха утром");
            string utrom = Console.ReadLine();
            Console.WriteLine("Введите температуру воздуха вечером");
            string vecherom = Console.ReadLine();
            int a = Convert.ToInt32(utrom);
            int b = Convert.ToInt32(vecherom);
            int c = (a + b) / 2;
            int d = b - a;
            Console.WriteLine($"Среднее ариф знач: {c}");
            Console.WriteLine($"Вечер минус утро: {d}");

        }
    }
}