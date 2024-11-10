/*1- Write a program and ask the user to enter a few numbers separated by a hyphen. 
 * Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or 
 * "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
*/

using System;

public class Class1
{
	public Class1()
	{
        Console.Write("Enter a few numbers separated by a hyphen: ");
        var input = Console.ReadLine();

        var numbers = input.Split('-').Select(int.Parse).ToList();

        bool isConsecutive = true;
        for (int i = 1; i < numbers.Count; i++)
        {
            if (Math.Abs(numbers[i] - numbers[i - 1]) != 1)
            {
                isConsecutive = false;
                break;
            }
        }

        Console.WriteLine(isConsecutive ? "Consecutive" : "Not Consecutive");
    }
}
