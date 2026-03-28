using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.PortableExecutable;
using System.Text;

/*
 * Reference:
 * Troelsen, A. and Japikse, P. (2022). Pro C# 10 with .NET 6: Foundational principles and practices in programming. 11th edition ed. Apress.
 * ASCII Everything. (2024). The Role of ASCII Art in Cybersecurity Awareness Campaigns. [online] Available at: https://asciieverything.com/ascii-blog/the-role-of-ascii-art-in-cybersecurity-awareness-campaigns/ [Accessed 28 Mar. 2026].ub
*/

namespace BasicChatbotPart1
{
    internal class UIHelper
    {
        public static void PrintHeader()
        { 
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("          CYBERSECURITY AWARENESS CHATBOT    ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.ResetColor();

        }

        //This is a simple ASCII logo on question 2
        public static void PrintAsciiLogo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(@"
               -------------
              |             |
              |             |
              |    LOCK     |
              |             |
              |_____________|
                    ||
                    ||
                    ||
                    ^^
              CYBERSECURITY

            ");

            Console.ResetColor();
        }

        //Divider method
        public static void Divider()
        {
            Console.WriteLine("-----------------------------------------------------------");
        }

        //This is the typing effect
        public static void TypingEffect(string message)
        {
            foreach (char character in message)
            {
                Console.Write(character);
                Thread.Sleep(24); 
            }
            Console.WriteLine();
        }

        //Added method which makes the bot to think (Thinking effect)
        public static void BotThinking()
        {
            Console.ForegroundColor= ConsoleColor.DarkGray;

            Console.WriteLine("Bot is thinking ");
            for (int j = 0; j < 10; j++)
            {
                Console.Write(".");
                Thread.Sleep(300); 
            }
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
