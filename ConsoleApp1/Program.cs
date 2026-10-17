using System;
namespace ConsoleApp1
{
    class Program
    {
        static int fib(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return fib(n - 1) + fib(n - 2);
            }
        }
       
        static void Main()
        {
            Console.WriteLine("Введите число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Значение {a} числа: {fib(a)} ");
           

        }
    }
}