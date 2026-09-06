namespace CybersecurityAwarenessBot.Part1;

public class ResponseHandler
{
    private readonly Random _random = new();

    private readonly Dictionary<string, string[]> _responses = new(StringComparer.OrdinalIgnoreCase)
    {
        ["password"] = new[]
        {
            "Use a long, unique password or passphrase for each important account.",
            "Avoid using names, birthdays, school details, or other easy-to-guess personal information in passwords.",
            "Where available, enable multi-factor authentication as an extra layer of account protection."
        },
        ["phishing"] = new[]
        {
            "Be cautious of unexpected emails or messages asking for passwords or personal information.",
            "Check links carefully and verify unusual requests through a trusted channel.",
            "Scammers can imitate trusted organisations, so do not rely on appearance alone."
        },
        ["browsing"] = new[]
        {
            "Keep your browser and operating system updated.",
            "Be cautious with unexpected downloads and browser security warnings.",
            "Use trusted websites and check addresses before entering sensitive information."
        }
    };

    public string GetResponse(string userInput, UserProfile profile)
    {
        string input = userInput.Trim().ToLowerInvariant();

        if (input.Contains("how are you"))
            return $"I'm doing well, {profile.Name}! I'm ready to help you stay safer online.";

        if (input.Contains("purpose") || input.Contains("what do you do"))
            return "My purpose is to provide practical cybersecurity awareness guidance.";

        if (input.Contains("what can i ask") || input.Contains("what can you help"))
            return "You can ask me about password safety, phishing and safe browsing.";

        if (input.Contains("what is your name") || input.Contains("who are you"))
            return "I am the Cybersecurity Awareness Bot.";

        if (input.Contains("password"))
            return RandomResponse("password");

        if (input.Contains("phishing"))
            return RandomResponse("phishing");

        if (input.Contains("safe browsing") || input.Contains("browsing") || input.Contains("browser"))
            return RandomResponse("browsing");

        return "I didn't quite understand that. Could you rephrase your question?";
    }

    private string RandomResponse(string topic)
    {
        string[] responses = _responses[topic];
        return responses[_random.Next(responses.Length)];
    }
}
