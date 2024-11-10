/* 2- Write a program and ask the user to enter their name. Use an array to reverse the name and 
 * then store the result in a new string. Display the reversed name on the console. */

using System;

public class Class1
{
    public Class1()
    {

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        // Converting name to a char array, reversing it and creating a new string from the reversed array.
        char[] nameArray = name.ToCharArray();
        Array.Reverse(nameArray);
        string reversedName = new string(nameArray);

        Console.WriteLine("Reversed name: " + reversedName);
    
}

}

