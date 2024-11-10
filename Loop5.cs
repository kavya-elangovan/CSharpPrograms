/* 5.Write a program and ask the user to enter a series of numbers separated by comma. 
 * Find the maximum of the numbers and display it on the console. For example, if the user
 * enters “5, 3, 8, 1, 4", the program should display 8.*/

using System;

public class Class1
{
	public Class1()
	{
      
            Console.Write("Enter a series of numbers separated by commas (e.g., 1,2,3): ");
            string input = Console.ReadLine();

            // The input string is splitted into an array of numbers and parsed  into integers
            var numbers = input.Split(',').Select(int.Parse).ToArray();

            // Find the maximum number in the array
            int maxNumber = numbers.Max();

            // Display the maximum number
            Console.WriteLine("The maximum number is: " + maxNumber);
        }
    }

}
}
