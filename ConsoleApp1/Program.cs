using System;
class Program
{
    static int nod(int a, int b)
    {

        while (b != 0)
        {
            int c = b;
            b = a % b;
            a = c;
        }
        return a;
    }
    static int nod(int a, int b, int c)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        c = Math.Abs(c);

        return nod(nod(a, b), c);
    }
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите третье число:");
        int z = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"НОД чисел {x} и {y} и {z} = {nod(x, y, z)}");


    }

}
