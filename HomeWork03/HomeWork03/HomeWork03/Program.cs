using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork03
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine($"Even Or Odd: 1\nBlackJack Card Count: 2\nPrime Number Check: 3\nExit to close");
                switch (Console.ReadLine())
                {
                    case "1": EvenOrOddNumber(); break;
                    case "2": BlackJackCardCounter(); break;
                    case "3": PrimeNumberCheck(); break;
                    case "Exit": break;
                }
                
            }
            return;

        }

        public static void EvenOrOddNumber()
        {
            Console.WriteLine("Input number");
            int inputNumber = Int32.Parse(Console.ReadLine());
            if (inputNumber % 2 == 0)
            {
                Console.WriteLine("Even!");
            }
            else
            {
                Console.WriteLine("Odd!\n");
            }
        }

        public static void BlackJackCardCounter()
        {
            Console.WriteLine("How many cards do you have?");
            int handCount = Int32.Parse(Console.ReadLine());
            int hand = 0;
           
            for (int i = 1; i <= handCount; i++)
            {
                Console.WriteLine($"Your {i} card is? :");
                
                string card = Console.ReadLine();

                switch(card)
                {
                    case "2": hand += 2; break;
                    case "3": hand += 3; break;
                    case "4": hand += 4; break;
                    case "5": hand += 5; break;
                    case "6": hand += 6; break;
                    case "7": hand += 7; break;
                    case "8": hand += 8; break;
                    case "9": hand += 9; break;
                    case "10": hand += 10; break;
                    case "J": hand += 10; break;
                    case "Q": hand += 10; break;
                    case "K": hand += 10; break;
                    case "A": hand += 10; break;       
                }
            }

            Console.WriteLine($"Your total score is: {hand}\n");
        }

        public static void PrimeNumberCheck()
        {
            Console.WriteLine("Enter number");
            int number = Int32.Parse(Console.ReadLine());
            bool isPrime = true;

            for(int i = number; --i != 1;)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine($"Your number prime: {isPrime}\n");
        }
    }
}
