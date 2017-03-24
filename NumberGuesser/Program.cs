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
            
            Random randomNumber = new Random();
            int rangedRandomNumber = randomNumber.Next(1, 101);

            for(int i = 0; i <5; i++)
            {
                Console.Write("Please guess a number between 1 and 100: ");
                string guessedNumber = Console.ReadLine();
                int parsedNumber = 0;

                if (int.TryParse(guessedNumber, out parsedNumber))
                {
                    Console.Write($"You guessed {parsedNumber}. ");
                    if (parsedNumber < rangedRandomNumber)
                    {
                        Console.Write($"{parsedNumber} is less than the correct answer, try again. You have {4 - i} chance(s) left. ");
                        
                    }
                    else if (parsedNumber > rangedRandomNumber)
                    {
                        Console.Write($"{parsedNumber} is greater than the correct answer, try again. You have {4 - i} chance(s) left. ");
                        
                    }
                    else if (parsedNumber == rangedRandomNumber)
                    {
                        Console.Write("Yay, you are correct! ");
                        i = 5;
                    }
                }
                else
                {
                    Console.Write($"That is not a valid number. You have {4 - i} chance(s) left. ");
                    
                }
            }
            Console.WriteLine("You ran out of guesses.");
        }
    }
} 
