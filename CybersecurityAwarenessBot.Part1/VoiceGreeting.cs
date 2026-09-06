using System.Media;

namespace CybersecurityAwarenessBot.Part1;

public class VoiceGreeting
{
    public bool PlayGreeting()
    {
        string path = Path.Combine(AppContext.BaseDirectory, "Audio", "greeting.wav");

        if (!File.Exists(path))
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Voice greeting not found. Add your own Audio/greeting.wav recording when ready.");
            Console.ResetColor();
            return false;
        }

        try
        {
            using var player = new SoundPlayer(path);
            player.PlaySync();
            return true;
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"The voice greeting could not be played: {ex.Message}");
            Console.ResetColor();
            return false;
        }
    }
}
