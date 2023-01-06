using System;
using CommonsLibrary;

namespace Hangman
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Welcome to Hangman!");
            Introduction();
        }

        private static void Introduction()
        {
            Console.WriteLine("You will have 10 chances to guess the word.");
            Console.WriteLine("If you guess the word correctly, you win!");
            Console.WriteLine("If you run out of chances, you lose!");
            Console.WriteLine("You can have someone choose a word or one can be chosen at random.");
            Console.WriteLine("Enjoy!");
        }

        private static string GetWord()
        {
            int numberOfLines = FileIO.TotalLines("\\File\\brit-a-z.txt");
            Random random = new Random();
            return FileIO.LineAt("\\File\\brit-a-z.txt", random.Next(0, numberOfLines));
        }
    }
}