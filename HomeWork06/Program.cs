using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace HomeWork06
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "D:/someting/Skillbox/CSharp/HomeWork06/Employee.txt";

            while(true)
            {
                Console.WriteLine("1: Список сотрудников\n2: Записать нового сотрудника\n3: Выйти");
                switch(Console.ReadLine())
                {
                    case ("1"): ReadFile(); break;
                    case ("2"): WriteNewEmployee(); break;
                    case ("3"): break;
                }
            }
        }

        /// <summary>
        /// Читает файл и выводит данные сотрудников
        /// </summary>
        private static void ReadFile()
        {
            try 
            {
                using (StreamReader sr = new StreamReader("database.txt", Encoding.Unicode))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] stringSplitted = line.Split('#');
                        foreach (string item in stringSplitted)
                        {
                            Console.WriteLine(item);
                        }
                    }
                }
            }
            catch(System.IO.FileNotFoundException)
            {
                Console.WriteLine("Файла не существует, добавьте сотрудника");
            }
        }


        /// <summary>
        /// Записывает сотрудника в файл
        /// </summary>
      
        private static void WriteNewEmployee()
        {
            char key = 'д';

            using (StreamWriter sw = new StreamWriter("database.txt", true, Encoding.UTF8))
            {
                do
                {
                    string lineToAdd = string.Empty;

                    Console.WriteLine("Введите ID:");
                    short employeeId = System.Int16.Parse(Console.ReadLine());
                    lineToAdd += ($"{employeeId}#");

                    string currentTime = DateTime.Now.ToString();
                    Console.WriteLine($"Текущее время: {currentTime}");
                    lineToAdd += ($"{currentTime}#");

                    Console.WriteLine("Введите фамилию имя и отчество сотрудника:");
                    string fullName = Console.ReadLine();
                    lineToAdd += ($"{fullName}#");

                    Console.WriteLine("Введите возраст сотрудника:");
                    short age = System.Int16.Parse(Console.ReadLine());
                    lineToAdd += ($"{age}#");

                    Console.WriteLine("Введите рост сотрудника:");
                    short height = System.Int16.Parse(Console.ReadLine());
                    lineToAdd += ($"{height}#");

                    Console.WriteLine("Введите дату рождения сотрудника:");
                    DateTime dateOfBirth = System.DateTime.Parse(Console.ReadLine());
                    lineToAdd += ($"{dateOfBirth.ToShortDateString()}#");

                    Console.WriteLine("Введите место рождения сотрудника:");
                    string placeOfBirth = Console.ReadLine();
                    lineToAdd += ($"город {placeOfBirth}#");

                    sw.Write(lineToAdd);

                    Console.WriteLine("Добавить еще одного сотрудника д/н");
                    key = Console.ReadKey(true).KeyChar;
                } 
                while (char.ToLower(key) == 'д');
            }
        }
    }
}
