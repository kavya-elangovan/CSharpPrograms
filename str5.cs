/* 5- Write a program and ask the user to enter an English word. Count the number of vowels 
 * (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 6 
 * on the console.*/
using System;

public class Class1
{
	public Class1()
	{
        Console.Write("Enter an English word: ");
        var input = Console.ReadLine().ToLower();

        int vowelCount = 0;
        foreach (var letter in input)
        {
            if ("aeiou".Contains(letter))
            {
                vowelCount++;
            }
        }

        Console.WriteLine("Number of vowels: " + vowelCount);
    }
}
