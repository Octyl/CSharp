using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вывод данных 
            string fullName = "Иванов Иван Иванович";
            ushort age = 17;
            string email = "IIvanov@yandex.ru";
            float programingScore = 4.1f;
            float mathScore = 3.9f;
            float physicsScore = 3.3f;

            Console.WriteLine($"Имя: {fullName}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Почта: {email}");
            Console.WriteLine($"Баллы по программированию: {programingScore}");
            Console.WriteLine($"Баллы по математике: {mathScore}");
            Console.WriteLine($"Баллы по физике: {physicsScore}\n");

            Console.ReadKey();

            //Вывод среднего балла
            float sum = programingScore + mathScore + physicsScore;
            float average = sum / 3;
            Console.WriteLine($"Средний балл: {average.ToString("#.##")}");

            Console.ReadKey();
        }
    }
}
