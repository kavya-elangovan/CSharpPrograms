/* 3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered,
 * display an error message and ask the user to re-try. Once the user successfully enters 5 unique
 * numbers, sort them and display the result on the console. */

using System;

public class Class1
{
	public Class1()
	{
        var numbers = new List<int>();

        while (numbers.Count < 5)
        {
            Console.Write("Enter a unique number: ");
            int number = int.Parse(Console.ReadLine());

            if (numbers.Contains(number))
            {
                Console.WriteLine("You've already entered this number. Try a different one.");
            }
            else
            {
                numbers.Add(number);
            }
        }

        numbers.Sort();
        Console.WriteLine("Sorted numbers: " + string.Join(", ", numbers));
    }
}
