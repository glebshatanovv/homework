using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();
        int[] array = new int[20];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(1, 101);
        }
        Console.WriteLine("Исходный массив:");
        Console.WriteLine(string.Join(" ", array));
        Console.WriteLine();
        Console.Write("Введите первое число из массива: ");
        if (!int.TryParse(Console.ReadLine(), out int num1))
        {
            Console.WriteLine("Ошибка");
            return;
        }

        Console.Write("Введите второе число из массива: ");
        if (!int.TryParse(Console.ReadLine(), out int num2))
        {
            Console.WriteLine("Ошибка.");
            return;
        }

        int res1 = Array.IndexOf(array, num1);
        int res2 = Array.IndexOf(array, num2);


        if (res1 != -1 && res2 != -1)
        {

            (array[res1], array[res2]) = (array[res2], array[res1]);


            Console.WriteLine("Получившийся массив:");
            Console.WriteLine(string.Join(" ", array));
        }
        else
        {
            Console.WriteLine("Ошибка: одно или оба числа отсутствуют в массиве.");
        }
    }
}
