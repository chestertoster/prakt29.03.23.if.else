using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstValue, secondValue, thirdValue, sum = 0;

            Console.Write("Введите 3 разных числа: ");
            firstValue = int.Parse(Console.ReadLine());
            if (firstValue > 0)
            {
                sum+= firstValue;
            }

            Console.Write("Ещо 2 числа: ");
            secondValue = int.Parse(Console.ReadLine());
            if (secondValue > 0)
            {
                sum += secondValue;
            }
            Console.Write("Ещооо 1 число: ");
            thirdValue = int.Parse(Console.ReadLine());
            if (thirdValue > 0)
            {
                sum += thirdValue;
            }

            if (sum > 0)
            {
                Console.WriteLine($"Сумма положительных числел: {sum}.");
            }
            else
            {
                Console.WriteLine("Положительных чисел нет.");
            }
        }
    }
}
