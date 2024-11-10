﻿/*4- Write a program and ask the user to enter a few words separated by a space. 
 * Use the words to create a variable name with PascalCase. For example, if the user types:
 * "number of students", display "NumberOfStudents". Make sure that the program is not 
 * dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still
 * display "NumberOfStudents". */

using System;

public class Class1
{
	public Class1()
	{
        Console.Write("Enter a few words separated by a space: ");
        var input = Console.ReadLine();

        var words = input.ToLower().Split(' ');

        var pascalCase = string.Join("", words.Select(w => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(w)));

        Console.WriteLine("PascalCase: " + pascalCase);
    }
}
