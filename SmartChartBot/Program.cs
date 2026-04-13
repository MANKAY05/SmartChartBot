using System;

class Program
{
    static void Main(string[] args)
    {
        // Play voice greeting
        VoiceGreeting.PlayGreeting();    

        // Display ASCII Logo
        Chatbot.DisplayLogo();

        // Start chatbot interaction
        Chatbot bot = new Chatbot(); 
        bot.Start(); 
    }
} 