using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Generate a random number between 1 and 100
                Prompt the user for a guess
                If the guess is less than the program's number, it should tell you that you were low and let you guess again.
                If the guess is greater than the program's number, it should tell you that you were high and let you guess again.
                If the guess is correct, the program should tell you that you win and then quit.
                After 5 incorrect guesses, the program should tell you that you lose.
                You should display all the guesses to the screen */
            Random randomNumber = new Random();
            int rangedRandomNumber = randomNumber.Next(0, 100);

            Console.Write("Please guess a number between 1 and 100: ");
            string guessedNumber = Console.ReadLine();
            int parsedNumber = 0;
            
            if (int.TryParse(guessedNumber, out parsedNumber))
            {
                Console.Write($"You guessed {parsedNumber}. ");
                if (parsedNumber < rangedRandomNumber)
                {
                    Console.Write($"{parsedNumber} is less than the correct answer, try again. ");
                } else if (parsedNumber > rangedRandomNumber)
                {
                    Console.Write($"{parsedNumber} is greater than the correct answer, try again. ");
                } else if (parsedNumber == rangedRandomNumber)
                {
                    Console.Write("Yay, you are correct!");
                }
            } else
            {
                Console.Write("That is not a valid number. ");
            }          

        }
    }
}
