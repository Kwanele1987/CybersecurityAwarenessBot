namespace CybersecurityAwarenessBot.Models;

public class CyberTask
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public DateTime? ReminderDate { get; set; }
    public bool IsCompleted { get; set; }

    public string ReminderDisplay =>
        ReminderDate.HasValue ? ReminderDate.Value.ToString("dd MMM yyyy") : "No reminder";

    public string Status => IsCompleted ? "Completed" : "Pending";
}
