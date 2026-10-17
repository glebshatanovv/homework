using System;
class Program
{
    static int nod(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);

        while (b != 0)
        {
            int c = b;
            b = a % b;
            a = c;
        }
        return a;

    }
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"НОД чисел {x} и {y} = {nod(x,y)}");


    }
}