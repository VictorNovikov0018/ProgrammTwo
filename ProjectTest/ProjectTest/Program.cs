using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Игорев Игорь Игорьевич"; //Названия в стиле camelCase
            string email = "igor245@mail.ru";
            byte age = 25;
            double programmingBalls = 78.5;
            double mathematicsBalls = 89.7;
            double physicsBalls = 65.3;
            Console.WriteLine($"Имя: {fullName}" +
                $"\nВозраст: {age}" +
                $"\nПочта: {email}" +
                $"\nБаллы по программированию: {programmingBalls}" +
                $"\nБаллы по математике: {mathematicsBalls}" +
                $"\nБаллы по физике: {physicsBalls}");


            double sum = programmingBalls + mathematicsBalls + physicsBalls;
            double averageScore = sum / 3;
            string averageScoreForm = averageScore.ToString("#.##");
            Console.WriteLine($"Сумма баллов: {sum}" +
                $"\nСредний балл: {averageScoreForm}");

            Console.ReadLine();
        }
    }
}
