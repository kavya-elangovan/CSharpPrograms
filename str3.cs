/* 3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
 * A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; 
 * otherwise, display "Invalid Time". If the user doesn't provide any values, 
 * consider it as invalid time. */
using System;

public class Class1
{
	public Class1()
	{
        Console.Write("Enter a time in 24-hour format (e.g., 19:00): ");
        var input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Invalid Time");
            return;
        }

        var parts = input.Split(':');
        if (parts.Length == 2 &&
            int.TryParse(parts[0], out int hours) &&
            int.TryParse(parts[1], out int minutes) &&
            hours >= 0 && hours <= 23 &&
            minutes >= 0 && minutes <= 59)
        {
            Console.WriteLine("Ok");
        }
        else
        {
            Console.WriteLine("Invalid Time");
        }
    }
}
