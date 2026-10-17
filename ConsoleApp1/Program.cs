using System;
using System.Threading;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.ResetColor(); 
            Console.Write("\nВведите число от 0 до 9 (или 'exit'/'закрыть' для выхода): ");
            string input = Console.ReadLine();
            if (input.Equals("exit", StringComparison.OrdinalIgnoreCase) ||
                input.Equals("закрыть", StringComparison.OrdinalIgnoreCase))
            {
                break; 
            }
            if (!int.TryParse(input, out int number))
            {
                throw new FormatException("Ошибка: Вы ввели не число!");
            }

            if (number < 0 || number > 9)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White; 
                Console.Clear(); 
                Console.WriteLine("\n ОШИБКА: Число должно быть строго в диапазоне от 0 до 9!");
                Thread.Sleep(3000); 
                Console.ResetColor();
                Console.Clear(); 
                continue; 
            }

            DrawNumber(number);
        }
    }

   
    static void DrawNumber(int num)
    {
        Console.WriteLine($"\nРисуем цифру {num}:");
        switch (num)
        {
            case 0:
                Console.WriteLine(" ### \n#   #\n#   #\n#   #\n ### ");
                break;
            case 1:
                Console.WriteLine("  #  \n ##  \n  #  \n  #  \n ### ");
                break;
            case 2:
                Console.WriteLine(" ### \n#   #\n  ## \n #   \n#####");
                break;
            case 3:
                Console.WriteLine("#####\n    #\n ### \n    #\n#####");
                break;
            case 4:
                Console.WriteLine("#   #\n#   #\n#####\n    #\n    #");
                break;
            case 5:
                Console.WriteLine("#####\n#    \n#### \n    #\n#### ");
                break;
            case 6:
                Console.WriteLine(" ### \n#    \n#### \n#   #\n ### ");
                break;
            case 7:
                Console.WriteLine("#####\n    #\n   # \n  #  \n #   ");
                break;
            case 8:
                Console.WriteLine(" ### \n#   #\n ### \n#   #\n ### ");
                break;
            case 9:
                Console.WriteLine(" ### \n#   #\n ####\n    #\n ### ");
                break;
        }
    }
}
