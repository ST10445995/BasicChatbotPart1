using BasicChatbotPart1;
using System.Media;

/*
 * Reference:
 * Troelsen, A. and Japikse, P. (2022). Pro C# 10 with .NET 6: Foundational principles and practices in programming. 11th edition ed. Apress.
*/

internal class Program
{
    private static void Main(string[] args)
    {
        //The title 
        Console.Title = "Cybersecurity Awareness Chatbot";

        //This is the voice greeting
        PlayVoiceGreeting();

        //Background colour question 6
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();

        //This is the UI display  and ASCII logo
        UIHelper.PrintHeader();
        UIHelper.PrintAsciiLogo();

        //This is the start chatbot
        Chatbot bot1 = new Chatbot();
        bot1.Start();
        
    }

    //Playing thr WAV greeting with a proper exception handling
    private static void PlayVoiceGreeting()
    {
        //This part makes sure that the file is in my project folder
        string path = "greetings.wav";

        if (File.Exists(path))
        {
            try
            {
                SoundPlayer soundPlayer = new SoundPlayer(path);
                soundPlayer.Load();
                soundPlayer.PlaySync();
            }

            catch (FormatException e)
            {
                Console.WriteLine("Voice greeting could not be played.");

                //This part shows us the actual error or problemu
                Console.WriteLine("Error:" + e.Message);
            }
        }

        else
        {
            Console.WriteLine("Audio file not found: " + path);
        }
    }

        
}