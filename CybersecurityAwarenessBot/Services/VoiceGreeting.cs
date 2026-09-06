using System.IO;
using System.Media;


namespace CybersecurityAwarenessBot.Services;

/// <summary>
/// Handles the optional WAV greeting used by the chatbot.
/// The student supplies their own recording as Audio/greeting.wav.
/// </summary>
public class VoiceGreeting
{
    public bool PlayGreeting(out string message)
    {
        string path = Path.Combine(AppContext.BaseDirectory, "Audio", "greeting.wav");

        if (!File.Exists(path))
        {
            message = "Voice greeting not found. Add your own recording as Audio/greeting.wav when ready.";
            return false;
        }

        try
        {
            using var player = new SoundPlayer(path);
            player.Play();
            message = "Voice greeting played.";
            return true;
        }
        catch (Exception ex)
        {
            message = $"Voice greeting could not be played: {ex.Message}";
            return false;
        }
    }
}
