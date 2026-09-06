# Cybersecurity Awareness Assistant
## PROG6221/w Programming 2A – POE

**Student:** Kwanele Langa  
**Student Number:** ST10500677

This solution contains the corrected Part 1 console implementation and the final WPF POE application. Part 1 has been restructured to follow the supplied Part 1 breakdown (steps 9–27), while the final WPF application retains the task assistant, quiz, NLP simulation, memory/sentiment handling and activity log.

## Solution structure

```text
CybersecurityAwarenessBot.sln
│
├── CybersecurityAwarenessBot.Part1
│   ├── Program.cs
│   ├── Chatbot.cs
│   ├── ResponseHandler.cs
│   ├── UserProfile.cs
│   ├── AsciiArt.cs
│   ├── VoiceGreeting.cs
│   └── Audio
│       ├── greeting.wav        <-- ADD YOUR OWN RECORDING
│       └── README.txt
│
└── CybersecurityAwarenessBot
    ├── MainWindow.xaml
    ├── MainWindow.xaml.cs
    ├── Models
    ├── Services
    │   ├── ChatbotService.cs
    │   ├── VoiceGreeting.cs
    │   ├── AsciiArtService.cs
    │   ├── MySqlTaskRepository.cs
    │   └── ActivityLogService.cs
    ├── Audio
    │   ├── greeting.wav        <-- ADD THE SAME OWN RECORDING
    │   └── README.txt
    └── database.sql
```

## Part 1 – corrected to the supplied breakdown

The console project now follows the requested separation of responsibilities:

- `Program.cs` starts the application through `Chatbot.Start()`.
- `VoiceGreeting.cs` locates and plays `Audio/greeting.wav`.
- `AsciiArt.cs` contains `DisplayLogo()`.
- `UserProfile.cs` stores the user name using an automatic `Name` property.
- `Chatbot.cs` controls the startup sequence and conversation loop.
- `ResponseHandler.cs` converts input to lowercase, checks recognised questions/topics and returns responses.
- Blank input is validated without crashing or terminating the program.
- Unsupported questions receive a friendly default response.
- Console colours and the optional typing effect are used consistently.

The startup sequence is:

```text
Play voice greeting
      ↓
Display ASCII art
      ↓
Ask for user's name
      ↓
Validate name
      ↓
Display personalised greeting
      ↓
Start conversation loop
```

## Voice recording

The voice recording is intentionally **not included yet**, because it must be your own voice.

Record the suggested greeting in your own voice:

> Hello! My name is Kwanele Langa. Welcome to the Cybersecurity Awareness Assistant. I am here to help you learn how to stay safe online.

Save the file exactly as:

`greeting.wav`

and place it in both:

- `CybersecurityAwarenessBot.Part1/Audio/`
- `CybersecurityAwarenessBot/Audio/`

The project files are already configured to copy the WAV file to the output directory when it is present. The applications also continue running if the recording has not been added yet.

## Final POE application

The WPF application includes:

### Chatbot / NLP
- Password safety responses
- Phishing responses
- Scam awareness
- Privacy guidance
- Safe browsing guidance
- General questions
- Keyword recognition
- Random responses
- Follow-up responses
- Memory of the user's name and favourite topic
- Simple sentiment detection for worried, curious and frustrated inputs
- Graceful unknown-input handling

### Task Assistant / MySQL
- Add tasks
- View tasks
- Optional reminder date
- Mark tasks completed
- Delete tasks
- MySQL storage

### Cybersecurity quiz
- 12 questions
- Multiple-choice / true-false style questions
- Immediate feedback
- Explanations
- Score calculation
- Final result

### Activity log
- Records important interactions and actions
- Displays the latest 10 activities

## MySQL setup

1. Start MySQL Server.
2. Open MySQL Workbench.
3. Run `database.sql`.
4. Open `CybersecurityAwarenessBot/Services/MySqlTaskRepository.cs`.
5. Change the `User` and `Password` constants to match your MySQL installation.
6. Build and run the WPF project.

The application also attempts to create the database and `tasks` table automatically when it starts if the MySQL account has permission to do so.

## Running the solution

1. Open `CybersecurityAwarenessBot.sln` in Visual Studio 2022.
2. Restore NuGet packages.
3. For the final POE, set `CybersecurityAwarenessBot` as the startup project.
4. Press F5.
5. For Part 1 demonstration, set `CybersecurityAwarenessBot.Part1` as the startup project and press F5.

## Before submission

You still need to add your own `greeting.wav`, test the complete application on your computer, create the required GitHub commits/releases/tags, and prepare the required presentation using your own voice.

The project cannot honestly be described as fully verified by compilation in this environment because Visual Studio/.NET SDK is not installed here. The source has been restructured against the supplied breakdown, but the final build should be performed in Visual Studio on your computer.
