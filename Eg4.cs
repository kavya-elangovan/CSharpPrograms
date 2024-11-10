/*4- Write a program and ask the user to continuously enter a number or type "Quit" to exit.
 * The list of numbers may include duplicates. Display the unique numbers that the user has entered.*/

using System;

public class Class1
{
	public Class1()
	{
        var numbers = new List<int>();

        while (true)
        {
            Console.Write("Enter a number (or type 'Quit' to exit): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            int number = int.Parse(input);

            if (!numbers.Contains(number))
            {
                numbers.Add(number);
            }
        }

        Console.WriteLine("Unique numbers entered: " + string.Join(", ", numbers));
	Console.ReadKey();
    }
}
