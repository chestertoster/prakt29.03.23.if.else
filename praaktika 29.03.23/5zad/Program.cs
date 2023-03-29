using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day;

            Console.Write("Введите число от 1 до 7 для того, чтобы узнать день недели: ");
            day = int.Parse(Console.ReadLine());

            if (day == 0)
            {
                Console.WriteLine("Ослик, вводи от 1 до 7!");
            }

            else if (day == 1)
            {
                Console.WriteLine("Красава, это Понедельник.");
            }

            else if (day == 2)
            {
                Console.WriteLine("Седня вторник.");
            }

            else if (day == 3)
            {
                Console.WriteLine("ВенZдей.");
            }

            else if (day == 4)
            {
                Console.WriteLine("Четверг - я заботы все отверг.");
            }

            else if (day == 5)
            {
                Console.WriteLine("Пятница с Ивлевым.");
            }

            else if (day == 6)
            {
                Console.WriteLine("Субота неработа.");
            }
            else if (day == 7)
            {
                Console.WriteLine("Воскресенье. НУЖНО слушать мальчик ягодный бабл гам не знаем чего хотеть но движемся в темноте отключив симку..)))");
            }
            else
            {
                Console.WriteLine("Попался, Ослик! Вводи от 1 до 7!");
            }
        }
    }
}
