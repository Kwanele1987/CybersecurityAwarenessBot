namespace CybersecurityAwarenessBot.Models;

public class QuizQuestion
{
    public string Question { get; set; } = "";
    public List<string> Options { get; set; } = new();
    public int CorrectIndex { get; set; }
    public string Explanation { get; set; } = "";

    public static List<QuizQuestion> GetQuestions() => new()
    {
        new() { Question = "What is phishing?", Options = new() {"A safe password method", "A deceptive attempt to steal information", "A type of antivirus", "A backup process"}, CorrectIndex = 1, Explanation = "Phishing uses deceptive messages or websites to trick people into revealing information." },
        new() { Question = "Which password is generally stronger?", Options = new() {"Kwanele123", "Password1", "A long unique passphrase", "Your birth date"}, CorrectIndex = 2, Explanation = "Long, unique passwords or passphrases are harder to guess." },
        new() { Question = "What should you do with a suspicious link?", Options = new() {"Click it immediately", "Share it with friends", "Verify the destination before opening it", "Enter your password first"}, CorrectIndex = 2, Explanation = "Check links carefully and use trusted routes to access important services." },
        new() { Question = "What does MFA add to an account?", Options = new() {"Another layer of verification", "A faster internet connection", "More storage", "A new email address"}, CorrectIndex = 0, Explanation = "Multi-factor authentication requires an additional verification factor." },
        new() { Question = "True or False: You should use the same password everywhere.", Options = new() {"True", "False"}, CorrectIndex = 1, Explanation = "Reusing passwords increases the impact if one account is compromised." },
        new() { Question = "Which is a safer browsing practice?", Options = new() {"Ignoring browser warnings", "Downloading from unknown sites", "Keeping your browser updated", "Disabling security features"}, CorrectIndex = 2, Explanation = "Updates often include security fixes." },
        new() { Question = "What is social engineering?", Options = new() {"Manipulating people to obtain information or access", "Building a social network", "Encrypting a file", "Installing updates"}, CorrectIndex = 0, Explanation = "Social engineering targets human behaviour rather than only technical weaknesses." },
        new() { Question = "What should you do if an email asks urgently for confidential information?", Options = new() {"Reply immediately", "Verify the request using a trusted contact method", "Forward it to everyone", "Post it online"}, CorrectIndex = 1, Explanation = "Urgency is a common social-engineering tactic, so verify independently." },
        new() { Question = "True or False: Public Wi-Fi always means your activity is private.", Options = new() {"True", "False"}, CorrectIndex = 1, Explanation = "Public networks can introduce risks; use secure connections and avoid unnecessary sensitive activity." },
        new() { Question = "Which action helps protect personal privacy?", Options = new() {"Reviewing privacy settings", "Sharing every detail publicly", "Using unknown apps", "Ignoring permissions"}, CorrectIndex = 0, Explanation = "Reviewing permissions and privacy settings reduces unnecessary data exposure." },
        new() { Question = "What is malware?", Options = new() {"Malicious software", "A password manager", "A secure browser", "A backup"}, CorrectIndex = 0, Explanation = "Malware is software designed to cause harm, disrupt systems, or gain unauthorised access." },
        new() { Question = "What should you do if you suspect an account has been compromised?", Options = new() {"Ignore it", "Change the password and follow the service's security guidance", "Share the password", "Delete all your devices"}, CorrectIndex = 1, Explanation = "Secure the account promptly and follow the provider's recovery and security steps." }
    };
}
