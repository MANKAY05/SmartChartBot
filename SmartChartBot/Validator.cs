using System;

public class Validator
{
    public static string ValidateInput(string input)
    {
        while (string.IsNullOrWhiteSpace(input))
        {
            Console.Write("⚠ Input cannot be empty. Try again: ");
            input = Console.ReadLine();   
        }

        return input; 
    }
}