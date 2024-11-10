/*2- Write a program and ask the user to enter a few numbers separated by a hyphen. 
 * If the user simply presses Enter, without supplying an input, exit immediately;
 * otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.*/

using System;

public class Class1
{
	public Class1()
	{
        Console.Write("Enter a few numbers separated by a hyphen: ");
        var input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
            return;

        var numbers = input.Split('-').Select(int.Parse).ToList();

        bool hasDuplicates = numbers.Count != numbers.Distinct().Count();

        Console.WriteLine(hasDuplicates ? "Duplicate" : "No Duplicate");
    }
}
