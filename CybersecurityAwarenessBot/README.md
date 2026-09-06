# Cybersecurity Awareness Assistant

## Student Information

**Student Name:** Kwanele Langa  
**Student Number:** ST10500677  
**Project:** Cybersecurity Awareness Assistant  
**Language:** C#  
**Framework:** .NET 8  
**GUI:** WPF  
**Database:** MySQL  

---

## 1. Project Overview

The Cybersecurity Awareness Assistant is a C# application designed to help users learn about basic cybersecurity concepts through an interactive chatbot, tasks and reminders, a cybersecurity quiz, and an activity log.

The project was developed in stages. Part 1 provides a command-line chatbot, while the main application provides a WPF graphical user interface with additional cybersecurity awareness features.

The application focuses on topics such as:

- Password safety
- Phishing
- Online scams
- Privacy
- Safe browsing
- Multi-factor authentication
- Cybersecurity tasks and reminders
- Cybersecurity knowledge testing

---

## 2. Main Features

### Chatbot

The chatbot allows the user to ask cybersecurity-related questions and receive relevant responses.

The chatbot supports:

- Password safety questions
- Phishing information
- Scam awareness
- Privacy guidance
- Safe browsing advice
- General cybersecurity questions
- Follow-up questions
- User name personalisation
- Favourite cybersecurity topic memory
- Basic sentiment detection
- Unsupported-input handling

### Voice Greeting

The application includes a voice greeting that can be played when the application starts or when the user selects the **Play Greeting** button.

The recording is stored as:

`Audio/greeting.wav`

The voice greeting is recorded in the student's own voice.

### ASCII Art

The application includes an ASCII cybersecurity logo to provide a visual identity for the chatbot.

### Task Assistant

The Task Assistant allows the user to:

- Add cybersecurity tasks
- Add task descriptions
- Set reminder dates
- View existing tasks
- Mark tasks as completed
- Delete tasks

Tasks are stored in a MySQL database.

### Cybersecurity Quiz

The application includes a cybersecurity knowledge quiz containing 12 questions.

The quiz provides:

- Multiple-choice questions
- Immediate feedback
- Correct and incorrect responses
- Explanations after answers
- A final score

### Activity Log

The Activity Log records recent actions performed in the application.

Examples include:

- Chatbot interactions
- Sentiment detection
- Follow-up detection
- Tasks added
- Tasks completed
- Tasks deleted

---

## 3. Project Structure

```text
CybersecurityAwarenessBot
│
├── CybersecurityAwarenessBot.sln
│
├── CybersecurityAwarenessBot
│   ├── App.xaml
│   ├── MainWindow.xaml
│   ├── MainWindow.xaml.cs
│   │
│   ├── Models
│   │   ├── CyberTask.cs
│   │   └── QuizQuestion.cs
│   │
│   ├── Services
│   │   ├── ActivityLogService.cs
│   │   ├── AsciiArtService.cs
│   │   ├── ChatbotService.cs
│   │   ├── MySqlTaskRepository.cs
│   │   └── VoiceGreeting.cs
│   │
│   ├── Audio
│   │   └── greeting.wav
│   │
│   ├── database.sql
│   └── README.md
│
└── CybersecurityAwarenessBot.Part1
    ├── Program.cs
    ├── Chatbot.cs
    ├── ResponseHandler.cs
    ├── UserProfile.cs
    ├── AsciiArt.cs
    ├── VoiceGreeting.cs
    │
    └── Audio
        └── greeting.wav