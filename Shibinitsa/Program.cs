using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        private static void Main(string[] args)
        {

            List<string> words = new List<string> { "cat", "money", "pancake", "notebook", "dog", "horse", "tree", "house", "car", "apple", "banana", "orange"};
            int index = new Random().Next(words.Count);
            string word = words[index];

            char[] symbols = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                symbols[i] = '*';
            }
            Console.WriteLine(symbols);
            int mistakeCount = 0;
            int guessCount = 0;

            while (true)
            {
                Console.WriteLine("Enter your guess:");
                char guess = char.Parse(Console.ReadLine());
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == guess)
                    {
                        symbols[i] = guess;
                        guessCount++;
                    }
                    else
                    {
                        mistakeCount++;
                    }
                }
                if (guessCount == word.Length)
                {
                    Console.WriteLine("Congratulations! You guessed the word!");
                    break;
                }
                else if (mistakeCount == 5)
                {
                    Console.WriteLine("You lose! The correct word was: " + word);
                    break;
                }

                Console.WriteLine("Word: " + new string(symbols));
                Console.WriteLine("Number of mistakes: " + mistakeCount);
            }
        }
    }
}
