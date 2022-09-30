using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Factorial = 0;
            float Result = 0;
            float First = 0;
            float Second = 0;
            int HowManyTimes = 0;
            bool IsDoing = true;
            do
            {
                if (HowManyTimes == 0)
                {
                    Console.WriteLine("1. Сложить 2 числа\r\n2. Вычесть первое из второго\r\n3. Перемножить два числа\r\n4. Разделить первое на второе\r\n5. Возвести в степень N первое число\r\n6. Найти квадратный корень из числа\r\n7. Найти 1 процент от числа\r\n8. Найти факториал из числа\r\n9. Выйти из программы");
                    HowManyTimes++;
                }
                else
                {
                    Console.WriteLine("Снова введите операцию.");
                }
                int Calculate = Convert.ToInt16(Console.ReadLine());
                switch (Calculate)
                {
                    case 1:
                        Console.WriteLine("Введите первое число.");
                        First = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        Second = Convert.ToInt32(Console.ReadLine());
                        Result = First + Second;
                        Console.WriteLine($"Полученный результат: {Result}");
                        break;
                    case 2:
                        Console.WriteLine("Введите первое число.");
                        First = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        Second = Convert.ToInt32(Console.ReadLine());
                        Result = First - Second;
                        Console.WriteLine($"Полученный результат: {Result}");
                        break;
                    case 3:
                        Console.WriteLine("Введите первое число.");
                        First = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        Second = Convert.ToInt32(Console.ReadLine());
                        Result = First * Second;
                        Console.WriteLine($"Полученный результат: {Result}");
                        break;
                    case 4:
                        Console.WriteLine("Введите первое число.");
                        First = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        Second = Convert.ToInt32(Console.ReadLine());
                        Result = First / Second;
                        Console.WriteLine($"Полученный результат: {Result}");
                        break;
                    case 5:
                        Console.WriteLine("Введите число.");
                        First = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите степень.");
                        Second = Convert.ToInt32(Console.ReadLine());
                        if (Second == 0)
                        {
                            Result = 1;
                        }
                        else
                        {
                            for (int i = 0; i <= Second; i++)
                            {
                                if (i == 0)
                                {
                                    Result = 1;
                                }
                                else
                                {
                                    Result *= First;
                                }
                            } 
                        }
                        Console.WriteLine($"Полученный результат: {Result}");
                        break;
                    case 6:
                        Console.WriteLine("Введите число.");
                        First = Convert.ToInt32(Console.ReadLine());
                        Result = (float)Math.Sqrt(First);
                        Console.WriteLine($"Полученный результат: {Result}");
                        break;
                    case 7:
                        Console.WriteLine("Введите число.");
                        First = Convert.ToInt32(Console.ReadLine());
                        Result = First / 100;
                        Console.WriteLine($"Полученный процент: {Result}");
                        break;
                    case 8:
                        Factorial = 0;
                        Console.WriteLine("Введите число.");
                        First = Convert.ToInt32(Console.ReadLine());
                        while(Factorial <= First)
                        {
                            if (Factorial == 0)
                            {
                                Result = 1;
                            }
                            else
                            {
                                Result *= Factorial;
                            }
                            Factorial++;
                        }
                        Console.WriteLine($"Полученный факториал: {Result}");
                        break;
                    case 9:
                        Console.WriteLine("Вы вышли из программы.");
                        IsDoing = false;
                        break;
                    default:
                        break;
                }
            } while (IsDoing);
        }
    }
}
