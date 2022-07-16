using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"1: Find sum of all numbers in array\n2: Find min number in array\n3: Guess the number\n4: Close");

            switch (Console.ReadLine())
            {
                case "1": FindSumInMatrix(); break;
                case "2": FindMinNumber(); break;
                case "3": GuessNumber(); break;
                case "4": break;
            }
        }

        public static void FindSumInMatrix()
        {
            Console.WriteLine("Enter number of rows: ");
            int rows = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of columns: ");
            int columns = Int32.Parse(Console.ReadLine());

            int[,] array = new int[rows, columns];
            int sum = 0;
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(0, 10);
                    sum += array[i, j];
                    Console.Write($"{array[i, j],2}");

                }
                Console.WriteLine();
            }

            Console.WriteLine($"array sum = {sum}");
            Console.ReadKey();
        }

        public static void FindMinNumber()
        {
            Console.WriteLine("Enter lenght: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine("Enter numbers");
            for (int i = 0; i < n; i++)
            {
                array[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            int min = int.MaxValue;

            for(int j = 0; j < array.Length; j++)
            {
                Console.Write($"{array[j], 3}");

                if (min > array[j] ){
                    min = array[j];
                }
            }

            Console.WriteLine($"\nMin number is: {min}");
            Console.ReadKey();
        }

        public static void GuessNumber()
        {
            Console.WriteLine("Enter upper range limit");
            Random random = new Random();
            int generatedNumber = random.Next(0, Int32.Parse(Console.ReadLine()));

            Console.WriteLine("Guess the number!");
            while(true)
            {
                string inputLine = Console.ReadLine();
                int guess;

                if (!int.TryParse(inputLine, out guess)){
                    Console.WriteLine($"Correct number was: {generatedNumber}");
                    break;
                }
                guess = Int32.Parse(inputLine);

                if(guess > generatedNumber){
                    Console.WriteLine("Less!");
                }
                else if(guess < generatedNumber){
                    Console.WriteLine("Greater!");
                }
                else{
                    Console.WriteLine("Correct!");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
