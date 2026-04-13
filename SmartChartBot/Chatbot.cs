using System;
using System.ComponentModel.DataAnnotations;

public class Chatbot
{
    private string clientName;

    public void Start()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n=== Welcome to Cybersecurity Awareness Bot ===\n");

        // Ask user name
        Console.Write("Enter your name: ");
        clientName = Console.ReadLine();

        clientName = Validator.ValidateInput(clientName); 

        Console.WriteLine($"\nHello {clientName}! How can I help you today?\n");

        // Start conversation loop
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("You: ");
            string input = Console.ReadLine();

            input = Validator.ValidateInput(input);

            string response = ResponseHandler.GetResponse(input);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bot: " + response);
             
            if (input.ToLower() == "exit")
                break;
        }
    }

    public static void DisplayLogo()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine(@"
   ██████╗██╗   ██╗██████╗ ███████╗██████╗ 
  ██╔════╝██║   ██║██╔══██╗██╔════╝██╔══██╗
  ██║     ██║   ██║██████╔╝█████╗  ██████╔╝
  ██║     ██║   ██║██╔═══╝ ██╔══╝  ██╔══██╗
  ╚██████╗╚██████╔╝██║     ███████╗██║  ██║
   ╚═════╝ ╚═════╝ ╚═╝     ╚══════╝╚═╝  ╚═╝

   🔐 CYBERSECURITY AWARENESS BOT 🔐
        ");
    }
}