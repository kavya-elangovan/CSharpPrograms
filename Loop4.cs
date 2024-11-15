﻿/*4. Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)
 */
using System;

public class Class1
{
	public Class1()
	{
            // To generate a random number between 1 and 10
            Random random = new Random();
		
            int secretNumber = random.Next(1, 11); // Generates a number between 1 and 10

            int attempts = 4;
            bool isGuessedCorrectly = false;

            // Give the user 4 attempts to guess the number
            for (int i = 0; i < attempts; i++)
            {
                Console.Write("Guess the number (between 1 and 10): ");
                int guess = int.Parse(Console.ReadLine());

                if (guess == secretNumber)
                {
                    Console.WriteLine("You won!");
                    isGuessedCorrectly = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong guess. Try again.");
                }
            }

            if (!isGuessedCorrectly)
            {
                Console.WriteLine("You lost.");
            }
 	    Console.ReadKey();
	}
}


