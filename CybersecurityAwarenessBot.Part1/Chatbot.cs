namespace CybersecurityAwarenessBot.Part1;

public class Chatbot
{
    private readonly VoiceGreeting _voiceGreeting = new();
    private readonly ResponseHandler _responseHandler = new();
    private readonly UserProfile _profile = new();

    public void Start()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Title = "Cybersecurity Awareness Bot";

        // 1. Play voice greeting.
        _voiceGreeting.PlayGreeting();

        // 2. Display ASCII art.
        AsciiArt.DisplayLogo();

        // 3. Ask for the user's name.
        AskForName();

        // 4. Validate the name.
        while (string.IsNullOrWhiteSpace(_profile.Name))
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("I did not catch your name. Please enter your name: ");
            Console.ResetColor();
            _profile.Name = Console.ReadLine()?.Trim() ?? "";
        }

        // 5. Display a personalised greeting.
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nBot: Welcome, {_profile.Name}! I am your Cybersecurity Awareness Assistant.");
        Console.WriteLine("You can ask me about:");
        Console.WriteLine("  • Password safety");
        Console.WriteLine("  • Phishing");
        Console.WriteLine("  • Safe browsing");
        Console.WriteLine("  • My purpose and general questions");
        Console.WriteLine("Type 'exit' when you want to close the chatbot.");
        Console.ResetColor();

        // 6. Start the chatbot conversation loop.
        ConversationLoop();
    }

    private void AskForName()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Please enter your name: ");
        Console.ResetColor();
        _profile.Name = Console.ReadLine()?.Trim() ?? "";
    }

    private void ConversationLoop()
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nYou: ");
            Console.ResetColor();

            string userInput = Console.ReadLine()?.Trim() ?? "";

            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Bot: Please type a question so that I can help you.");
                Console.ResetColor();
                continue;
            }

            if (userInput.Equals("exit", StringComparison.OrdinalIgnoreCase))
                break;

            string response = _responseHandler.GetResponse(userInput, _profile);
            DisplayResponse(response);
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nBot: Goodbye! Stay safe online.");
        Console.ResetColor();
    }

    private static void DisplayResponse(string response)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Bot: ");
        Console.ResetColor();

        // Optional typing effect from the guide. Kept short so testing is easy.
        foreach (char character in response)
        {
            Console.Write(character);
            Thread.Sleep(8);
        }

        Console.WriteLine();
    }
}
