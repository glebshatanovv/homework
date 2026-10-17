using System;
using System.Net.Sockets;
using System.Xml.Schema;
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
            // 2
            long product = 1;
            double sred;
            long sum = calculator(out sred,ref product, 5, 2, 4, 10);
            Console.WriteLine($"Сумма элементов (return): {sum}");
            Console.WriteLine($"Произведение элементов (ref): {product}");
            Console.WriteLine($"Среднее арифметическое (out): {sred:F2}");

        }
        static long calculator(out double sred, ref long umn, params int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                sred = 0;
                umn = 0;
                return 0;
            }
            long sum = 0;
            foreach (int num in numbers) 
            {
                sum += num;
                umn += num;
            }
            sred = sum / numbers.Length;
            return sum;
        }
        
    }
}