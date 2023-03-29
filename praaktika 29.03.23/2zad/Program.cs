using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue, thirdValue;

            Console.Write("Введите 3 разных числа: ");
            firstValue = double.Parse(Console.ReadLine());
            Console.Write("Ещо 2 числа: ");
            secondValue = double.Parse(Console.ReadLine());
            Console.Write("Ещооо 1 число: ");
            thirdValue = double.Parse(Console.ReadLine());

            if ((firstValue > secondValue) & (firstValue > thirdValue))
            {
                Console.WriteLine($"Первое число '{firstValue}' больше остальных.");
            }
            else if ((secondValue > firstValue) & (secondValue > thirdValue))
            {
                Console.WriteLine($"Второе число '{secondValue}' больше остальных.");
            }
            else if ((thirdValue > secondValue) & (thirdValue > firstValue))
            {
                Console.WriteLine($"Третье число '{thirdValue}' больше остальных.");
            }
            else
            {
                Console.WriteLine($"Вы ввели не разные числа!: '{firstValue}' '{secondValue}' '{thirdValue}'.");
            }
        }
    }
}
