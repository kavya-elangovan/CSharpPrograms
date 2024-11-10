/* 5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
 * If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
 * otherwise, display the 3 smallest numbers in the list. */
using System;

public class Class1
{
	public Class1()
	{
        while (true)
        {
            Console.Write("Enter a list of comma-separated numbers: ");
            string input = Console.ReadLine();

            var numbers = input.Split(',')
                               .Select(n => int.Parse(n.Trim()))
                               .ToList();

            if (numbers.Count < 5)
            {
                Console.WriteLine("Invalid List. Please enter at least 5 numbers.");
                continue;
            }

            var smallestNumbers = numbers.OrderBy(n => n).Take(3).ToList();
            Console.WriteLine("The 3 smallest numbers are: " + string.Join(", ", smallestNumbers));
            break;
        }
    }
}
