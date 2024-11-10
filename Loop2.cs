/* 2.Write a program and continuously ask the user to enter a 
 *   number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.  */

using System;

public class Class1
{
	public Class1()
	{
        int sum = 0;

        while (true)
        {
            Console.Write("Enter a number : ");
            string input = Console.ReadLine();

            if (input.ToLower() == "ok")
            {
                break;
            }

            if (int.TryParse(input, out int number))
            {
                sum += number;
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }

        Console.WriteLine("The sum of all entered numbers is: " + sum);
    }
}
