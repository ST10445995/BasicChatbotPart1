using System;
using System.Collections.Generic;
using System.Text;

/*
 * Reference:
 * Troelsen, A. and Japikse, P. (2022). Pro C# 10 with .NET 6: Foundational principles and practices in programming. 11th edition ed. Apress.
*/

//Menu system implemented

//Input validation and responses added

namespace BasicChatbotPart1
{
    internal class Chatbot
    {
        private string userName;

        //This is a method that is called from the Program.cs
        public void Start()
        {
            AskName();
            GreetUser();
            ChatLoop();
        }

        public void AskName()
        {
            while (true)
            {
                Console.Write("Please enter your name: ");
                userName = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(userName))
                    break;

                Console.WriteLine("The name can not be empty. Please kindly try again.");

            }
        }

        //Greeting the user with a typing effect
        private void GreetUser()
        {
            UIHelper.Divider();

            Console.ForegroundColor = ConsoleColor.Magenta;
            UIHelper.TypingEffect($"Hello {userName}! Welcome to the Cybersecurity Awareness Bot.");
            Console.ResetColor();

            Console.ForegroundColor= ConsoleColor.Gray;
            UIHelper.TypingEffect("\nMay you please choose an option below:");
            Console.ResetColor();

            ShowMenu();
        }

        //Method for menu display
        private void ShowMenu()
        {
            Console.ForegroundColor= ConsoleColor.DarkCyan;

            Console.WriteLine("\n=============== MENU ===============");
            Console.WriteLine("1. Password Safety");
            Console.WriteLine("2. Phishing");
            Console.WriteLine("3. Safe Browsing");
            Console.WriteLine("4. General Questions");
            Console.WriteLine("5. Exit");
            Console.WriteLine("---------------------------------------");

            Console.ResetColor();
        }

        //This is the main chat loop with a basic response
        private void ChatLoop()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\nPlease enter your preferred option from 1-5: ");
                string input = Console.ReadLine();

                //This is the input validation on Question 5
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please enter a valid option.");
                    continue;
                }

                UIHelper.BotThinking();

                Console.ForegroundColor = ConsoleColor.Green;

                switch (input)
                {
                    case "1":
                        UIHelper.TypingEffect("Use strong passwords with letters, numbers and symbols. Avoid personal inofrmation.");
                        break;

                    case "2":
                        UIHelper.TypingEffect("Phishing scams try to trick you into giving personal informations. Always verify the email senders and links.");
                        break;

                    case "3":
                        UIHelper.TypingEffect("Only visit secure websites that has https and avoid suspicious links.");
                        break;

                    case "4":
                        HandleGeneralQuestions();
                        break;

                    case "5":
                        UIHelper.TypingEffect("Goodbye! Stay safe online.");
                        return;

                    default:
                        UIHelper.TypingEffect("Invalid option. Please choose between 1 to 5.");
                        break;
                }

                Console.ResetColor();

                //This shows the menu again
                ShowMenu();
            }
        }


        //This is the general questions method
        private void HandleGeneralQuestions()
        {
            UIHelper.TypingEffect("You can ask me general questions. Type 'back' to return to the menu");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nPlease ask a question: ");
                string input = Console.ReadLine().ToLower().Trim();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please enter something.");
                    continue;
                }

                if (input == "back")
                {
                    UIHelper.TypingEffect("Returning to the main menu...");
                    break;
                }

                UIHelper.BotThinking();
                Console.ForegroundColor = ConsoleColor.Green;

                if (input.Contains("how are you?"))
                {
                    UIHelper.TypingEffect("I am doing great! Ready to help you stay safe online.");

                }

                else if (input.Contains("what's your purpose?"))
                {
                    UIHelper.TypingEffect("My purpose is to educate users about cybersecurity. ");
                }

                else if (input.Contains("what can i ask about you?"))
                {
                    UIHelper.TypingEffect("You can ask about the cybersecurity topics or general questions.");
                }
                
                else
                {
                    UIHelper.TypingEffect("I didn't quite understand that. Could you rephrase?");
                }

                Console.ResetColor();
            }
        }
    }
}
