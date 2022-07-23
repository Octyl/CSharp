using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork07
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "database.txt";
            Repository rep = new Repository(path);
            rep.LoadFromFile();

            while (true)
            {
                Console.WriteLine(
                    "1: Список сотрудников\n" +
                    "2: Записать нового сотрудника\n" +
                    "3: Удалить сотрудника\n" +
                    "4: Изменить сотрудника\n" +
                    "5: Сортировка по дате\n" +
                    "6: Сохранить изменения\n");

                switch (Console.ReadLine())
                {
                    case ("1"): rep.PrintAll(); break;
                    case ("2"): rep.AddEmployee(rep.CreateEmployee()); break;
                    case ("3"): rep.DeleteEmployee(); break;
                    case ("4"): rep.UpdateEmployee(); break;
                    case ("5"): rep.SortByBirthday(); break;
                    case ("6"): rep.SaveToFile(); break;
                }
            }
        }
    }
}
