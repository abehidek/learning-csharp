using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_course.basic_concepts
{
    class GuessGame
    {
        public static void Game()
        {
            string secretWord = "secretword";
            string guess = "";

            int guessNum = 0;
            int guessLim = 3;
            bool outOfGuess = false;
            Console.Clear();
            while (guess != secretWord && !outOfGuess)
            {
                if (guessNum < guessLim)
                {
                    Console.Write("Make your guess: ");
                    guess = Console.ReadLine();
                    guessNum++;
                }
                else
                    outOfGuess = true;
            }
            if (outOfGuess)
                Console.WriteLine("You lose");
            else
                Console.Write("You win");

            Console.ReadLine();
        }
    }
}
