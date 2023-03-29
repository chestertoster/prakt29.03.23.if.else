using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praaktika_29._03._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1zad.

            double value;
            string res;

            Console.Write("Введите положительное или отрицательное число: ");
            value = double.Parse(Console.ReadLine());
            res = value > 0 ? $"Вы ввели положительное число, и к числу прибавилось +5, ответ: {value + 5}." : $"Вы ввели отрицательное число, и к числу прибавилось -5, ответ: {value - 5}.";
            
            Console.WriteLine(res);
        }
    }
}
