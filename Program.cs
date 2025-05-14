using System;
using System.Speech.Synthesis;

namespace CyberChatBot
{
    class CybersecurityChatbot
    {
        static void Main(string[] args)
        {
            Greeting();
            DisplayAsciiLogo();
            string userName = GetUserName();
            DisplayWelcomeMessage(userName);
        }

        static void Greeting()
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("Welcome to the chatbot, Please enter your name.");
        }

        static void DisplayAsciiLogo()
        {
            string logo = @"
            ____ _           _           _____             _        _____                _       
           / ___| |_   _ ___| |__   ___  |_   _|__   __ _| |_ ___ | ____|_ __ ___   __ _| |_ ___ 
          | |   | | | | / __| '_ \ / _ \  | |/ _ \ / _` | __/ _ \|  _| | '_ ` _ \ / _` | __/ _ \
          | |___| | |_| \__ \ | | |  __/  | | (_) | (_| | || (_) | |___| | | | | | (_| | ||  __/
           \____|_|\__,_|___/_| |_|\___|  |_|\___/ \__,_|\__\___/|_____|_| |_| |_|\__,_|\__\___|
            ";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(logo);
            Console.ResetColor();
        }

        static string GetUserName()
        {
            Console.WriteLine("Hello! What is your name?");
            string name = Console.ReadLine().Trim();
            return name;
        }
    }
}
static void StartChatbotConversation()
{
    bool keepChatting = true;

    while (keepChatting)
    {
        DisplayMainMenu();
        string userInput = Console.ReadLine().ToLower().Trim();

        switch (userInput)
        {
            case "1":
                DiscussPasswordSafety();
                break;
            case "2":
                DiscussPhishing();
                break;
            case "3":
                DiscussSafeBrowsing();
                break;
            case "exit":
                keepChatting = false;
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a valid option.");
                break;
        }
    }
}

static void DisplayMainMenu()
{
    Console.WriteLine("1. Password Safety");
    Console.WriteLine("2. Phishing");
    Console.WriteLine("3. Safe Browsing");
    Console.WriteLine("Type 'exit' to quit.");
    Console.Write("> ");
}

static void DiscussPasswordSafety()
{
    string message = @"
    static string GetUserName()
{
    string name;
    do
    {
        Console.WriteLine("Hello! What is your name?");
        name = Console.ReadLine().Trim();
        if (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Please enter a valid name!");
        }
    } while (string.IsNullOrEmpty(name));

    return name;
}

    static void StartChatbotConversation()
{
    bool keepChatting = true;

    while (keepChatting)
    {
        DisplayMainMenu();
        string userInput = Console.ReadLine().ToLower().Trim();

        switch (userInput)
        {
            case "1":
                DiscussPasswordSafety();
                break;
            case "2":
                DiscussPhishing();
                break;
            case "3":
                DiscussSafeBrowsing();
                break;
            case "exit":
                keepChatting = false;
                break;
            default:
                Console.WriteLine("Invalid input. Please enter '1', '2', or '3'.");
                break;
        }
    }
}


