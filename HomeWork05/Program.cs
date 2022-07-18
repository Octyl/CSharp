using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork05
{
    class Program
    {
        static string userSentence;

        static void Main(string[] args)
        {
            //Print sentence as an array
            Console.WriteLine("Enter sentence: ");
            userSentence = Console.ReadLine();
            PrintArray(SplitSentence(userSentence));

            Console.ReadKey();

            //Reverse sentence
            string reversedSentence = null;
            reversedSentence = String.Join(" ", ReverseWords(SplitSentence(userSentence)));
            Console.WriteLine($"\n{reversedSentence}");

            Console.ReadKey();
        }

        /// <summary>
        /// Splits string to array
        /// </summary>
        /// <param name="sentence">string</param>
        /// <returns>returns array</returns>
        private static string[] SplitSentence(string sentence)
        {
            string[] sentenceArray = sentence.Split(' ');

            return sentenceArray;
        }

        /// <summary>
        /// prints array
        /// </summary>
        /// <param name="sentence">array</param>
        /// <returns>prints array in console, each word on a new line</returns>
        private static void PrintArray(string[] stringArray)
        {
            foreach(string word in stringArray)
            {
                Console.WriteLine(word);
            }
        }

        /// <summary>
        /// Reverses array
        /// </summary>
        /// <param name="sentence">array</param>
        /// <returns>returns reversed array</returns>
        private static string[] ReverseWords(string[] stringArray)
        {
            Array.Reverse(stringArray);

            return stringArray;
        }

    }
}
