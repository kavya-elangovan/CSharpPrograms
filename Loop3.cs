/* 3.  Write a program and ask the user to enter a number. Compute the factorial of the number and print 
 *    it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.   */


using System;

public class Class1
{
	public Class1()
	{
        Console.Write("Enter a number to calculate its factorial: ");
        if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
        {
            int factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"{number}! = {factorial}");
        }
        else
        {
            Console.WriteLine("Please enter a valid non-negative integer.");
        }
	Console.ReadKey();
    }
}
