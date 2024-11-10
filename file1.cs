/* 1- Write a program that reads a text file and displays the number of words. */

using System;

public class Class1
{
	public Class1()
	{
        Console.Write("Enter the file path: ");
        string filePath = Console.ReadLine();

        try
        {
            var content = File.ReadAllText(filePath);
            var words = content.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Number of words: " + words.Length);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
	Console.ReadKey();	
    }
}
