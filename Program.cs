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
