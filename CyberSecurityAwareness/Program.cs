using CyberSecurityAwareness;
using System;
//Input validation and error handling added
using System;
// Set console title
Console.Title = "Cybersecurity Awareness Bot";

// Display ASCII art
ConsoleUI.DisplayAsciiArt();


// Play voice greeting
AudioPlayer.PlayVoiceGreeting();

// Welcome box
ConsoleUI.PrintBorder();
ConsoleUI.PrintColored("║   Welcome to the Cybersecurity Awareness Bot!   ║\n", ConsoleColor.Cyan);
ConsoleUI.PrintBorderClose();

Console.WriteLine();

// Get user name
string userName = CybersecurityChatbot.InputHandler.GetUserName();



// Greet user
ConsoleUI.TypeEffect($"Hello, {userName}! I'm here to help you stay safe online.\n", ConsoleColor.Green);



// Instructions
ConsoleUI.PrintColored("Type 'exit' to quit the chatbot.\n\n", ConsoleColor.DarkGray);

// Chat loop
while (true)
{
    // User input
    ConsoleUI.PrintColored("You: ", ConsoleColor.Yellow);
    string userInput = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(userInput))
    {
        continue;
    }

    userInput = userInput.ToLower();

    // Exit condition
    if (userInput == "exit")
    {
        ConsoleUI.TypeEffect("Goodbye! Stay safe online 👋", ConsoleColor.Red);
        break;
    }

    // Inside your main loop
    ChatBotResponder responder = new ChatBotResponder();
    string response = responder.GetResponse(userInput);

    // Display response
    ConsoleUI.PrintColored("Bot: ", ConsoleColor.Cyan);
    ConsoleUI.TypeEffect(response + "\n", ConsoleColor.White);
}



