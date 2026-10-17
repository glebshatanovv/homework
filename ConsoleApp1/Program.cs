using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Rand = new Random();
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Rand.Next(1, 101);
            }
            Console.WriteLine($"Исходный массив: {array}");
            Console.WriteLine(string.Join(" ", array));
            Console.WriteLine("Выпишите первое число:");
            int num_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Выпишите второе число:");
            int num_2 = int.Parse(Console.ReadLine());
            int swap_1 = Array.IndexOf(array, num_1);
            int swap_2 = Array.IndexOf(array, num_2);
            if (swap_1 != -1 && swap_2 != -1)
            {
                (array[swap_1], array[swap_2]) = (array[swap_2], array[swap_1]);
                Console.WriteLine($"Новый массив: {string.Join(" ", array)}");
            }
            else
            {
                Console.WriteLine("Таких чисел нет в списке");
            }
        }
    }
}