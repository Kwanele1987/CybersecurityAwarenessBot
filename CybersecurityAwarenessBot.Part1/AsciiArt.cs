namespace CybersecurityAwarenessBot.Part1;

public static class AsciiArt
{
    public static void DisplayLogo()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("========================================================");
        Console.WriteLine("              CYBERSECURITY AWARENESS BOT              ");
        Console.WriteLine("========================================================");
        Console.WriteLine("                         /\\                             ");
        Console.WriteLine("                        /  \\                            ");
        Console.WriteLine("                       / /\\ \\                           ");
        Console.WriteLine("                      / /  \\ \\                          ");
        Console.WriteLine("                     /_/____\\_\\                         ");
        Console.WriteLine("                        |  |                              ");
        Console.WriteLine("                        |__|                              ");
        Console.WriteLine("                                                        ");
        Console.WriteLine("                     STAY SAFE ONLINE                   ");
        Console.WriteLine("========================================================");
        Console.ResetColor();
    }
}
