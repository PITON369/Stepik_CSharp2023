using System;
using System.Text;

namespace D_Practice
{
    internal class Homework0807
    {
        public void Game()
        {
            Console.WriteLine("New game.");
            int count = 6;
            var rand = new Random();
            string word = string.Empty;
            var showWord = new StringBuilder(string.Empty);
            string triedLetters = string.Empty;

            while (word == string.Empty)
                word = File.ReadLines("WordsStockRus.txt").Skip(rand.Next(1,11650)).First();
            foreach (var ch in word)
                showWord.Insert(showWord.Length, "-");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(showWord);
                Console.WriteLine($"Choose letter. Attempts left {count - i}");
                Console.WriteLine($"Your tried letters: {triedLetters}");
                string letter = string.Empty;
                while (letter == string.Empty)
                    letter = Console.ReadLine();
                triedLetters += letter + " ";
                if (word.Contains(letter))
                {
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (letter[0] == word[j]) 
                            showWord[j] = letter[0];
                    }
                }
                else
                    Console.WriteLine("Wrong!");
                if (!showWord.ToString().Contains("-"))
                {
                    Console.WriteLine("Win!");
                    break;
                }
            }
            Console.WriteLine("You loose!");
            Console.WriteLine($"Word is {word}.");
        }


    }
}