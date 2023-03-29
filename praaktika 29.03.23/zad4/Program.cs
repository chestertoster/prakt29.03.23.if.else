using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value, sum = 2;

            Console.Write("Введите число: ");
            value = int.Parse(Console.ReadLine());
            if (value >= 10)
            {
                sum *= value;
            }

            if (sum >= 10)
            {
                Console.WriteLine($"Ваше число удвоилось: {sum}.");
            }
            else
            {
                Console.WriteLine("Вы ввели число меньше 10, удвоения не будэ.");
            }
        }
    }
}
