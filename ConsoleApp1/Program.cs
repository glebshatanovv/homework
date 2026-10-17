using System;

class Program
{
    static void Main()
    {
        long umnoj = 1;
        double average;
        long sum = CalculateStats(out average, ref umnoj, 15, 20, 40, 100);

        Console.WriteLine($"Сумма элементов (через return): {sum}");
        Console.WriteLine($"Произведение элементов (через ref): {umnoj}");
        Console.WriteLine($"Среднее арифметическое (через out): {average:F2}");
    }
    static long CalculateStats(out double avg, ref long umn, params int[] numbers)
    {
 
        if (numbers == null || numbers.Length == 0)
        {
            avg = 0;
            umn = 0;
            return 0;
        }

        long sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
            umn *= num; 
        }
        avg = (double)sum / numbers.Length;
        return sum;
    }
}
