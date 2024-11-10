/* 2- Write a program that reads a text file and displays the longest word in the file.
*/


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

            var longestWord = words.OrderByDescending(word => word.Length).FirstOrDefault();
            Console.WriteLine("Longest word: " + longestWord);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
	Console.ReadKey();
    }
}
