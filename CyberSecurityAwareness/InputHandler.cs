using System;
using System.Collections.Generic;
using System.Text;

namespace CybersecurityChatbot
{
    internal class InputHandler
    {
        public static string GetUserName()
        {
            string name = "";

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nPlease enter your name: ");

                Console.ForegroundColor = ConsoleColor.White;
                name = Console.ReadLine();

                Console.ResetColor();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Name cannot be empty. Please try again.");
                    Console.ResetColor();
                }
            }

            return name.Trim();
        }
    }
}


