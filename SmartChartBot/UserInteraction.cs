using System;

public class UserInteraction
{
    public static void TypingEffect(string message)
    {
        foreach (char c in message)
        {
            Console.Write(c);
            System.Threading.Thread.Sleep(20);   
        }
        Console.WriteLine(); 
    }
}
