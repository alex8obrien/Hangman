using System;
using CommonsLibrary;

namespace Hangman
{
    internal static class Program
    {
        private static void Main()
        {
            Introduction();
            bool random = StdInp.InputYNAsBool("Would you like the word to be chosen at random?");
            string secretWord = string.Empty;
            bool play = true;

            do
            {
                if (random)
                { secretWord = GetWord(); }
                else
                { secretWord = StdInp.Input("Please enter the word you would like to use"); }

                
            } while (play);

        }

        private static void Introduction()
        {
            Console.WriteLine("Welcome to Hangman!");
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