[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/r7DYvnxq)
# 🛡️ Cybersecurity Awareness Chatbot

![.NET](https://img.shields.io/badge/.NET-10-blue)
![WPF](https://img.shields.io/badge/WPF-Windows-blueviolet)
![C%23](https://img.shields.io/badge/C%23-Language-green)
![GitHub Actions](https://img.shields.io/badge/CI-GitHub%20Actions-success)

A Cybersecurity Awareness Chatbot developed for the **Programming 2A (PROG6221)** Portfolio of Evidence.

The application is designed to educate South African citizens about common cybersecurity threats through an interactive graphical interface. It combines chatbot functionality with a cybersecurity task manager, quiz system, activity logging, and basic Natural Language Processing (NLP).

---

# 📖 Overview

Cybercrime continues to affect individuals and businesses worldwide. This chatbot helps users learn about online safety by providing guidance on topics including:

- Password security
- Phishing attacks
- Online scams
- Privacy protection
- Safe browsing
- Social engineering

The project was developed using **C#**, **Windows Presentation Foundation (WPF)** and **MySQL**.

---

# ✨ Features

## Part 1
- Voice greeting
- ASCII logo
- Personalized welcome message
- Basic cybersecurity chatbot
- Input validation
- Console formatting
- Object-Oriented design

---

## Part 2

- WPF Graphical User Interface
- Keyword recognition
- Dynamic chatbot responses
- Random cybersecurity tips
- Memory and recall
- Sentiment detection
- Improved conversation flow

---

## Part 3 (POE)

### 📝 Cybersecurity Task Manager

- Add tasks
- Edit tasks
- Delete tasks
- Mark tasks as completed
- Reminder support
- MySQL database integration

---

### 🎮 Cybersecurity Quiz

- Multiple-choice questions
- True/False questions
- Immediate feedback
- Final score
- Score summary

---

### 🧠 NLP Simulation

Recognises different ways users ask for:

- Tasks
- Reminders
- Password help
- Phishing advice
- Quiz commands

using keyword detection and string matching.

---

### 📋 Activity Log

Records important actions such as:

- Tasks added
- Tasks completed
- Tasks deleted
- Quiz attempts
- Reminder creation
- Chatbot actions

---

# 🛠 Technologies Used

- C#
- .NET 10
- Windows Presentation Foundation (WPF)
- XAML
- MySQL
- Visual Studio 2022
- Git
- GitHub
- GitHub Actions

---

# 📂 Project Structure

```
CyberSecurityAwarenessBot/
│
├── Assets/
│   ├── welcome.wav
│   ├── logo.txt
│
├── Database/
│   ├── SQL Scripts
│
├── Models/
│
├── Services/
│
├── Views/
│
├── ViewModels/
│
├── .github/
│   └── workflows/
│       └── dotnet.yml
│
├── App.xaml
├── MainWindow.xaml
└── README.md
```

---

# 🚀 Getting Started

## Requirements

- Windows 10/11
- Visual Studio 2022
- .NET 10 SDK
- MySQL Server

---

## Clone the Repository

```bash
git clone https://github.com/ST10448051/PROG6221_G2_2026_POE-Resubmission.git
```

---

## Open the Project

Open the solution in Visual Studio.

```
CyberSecurityAwarenessBot.sln
```

---

## Configure the Database

Create a MySQL database.

Example:

```
CyberSecurityBot
```

Update the connection string inside:

```
DatabaseService.cs
```

Example:

```csharp
Server=localhost;
Database=CyberSecurityBot;
Uid=root;
Pwd=YOUR_PASSWORD;
```

---

## Run the Application

Press

```
F5
```

or

```
Start Debugging
```

The application will launch.

---

# 💬 Example Commands

Examples of supported interactions:

```
Tell me about phishing

How do I create a strong password?

Start quiz

Add a task

Show my tasks

Delete task

Mark task completed

Show activity log

Remind me to update my password tomorrow
```

---

# 🗄 Database Features

The chatbot stores:

- Tasks
- Descriptions
- Reminder dates
- Completion status

using a MySQL database.

---

# 📸 Screenshots

## Main Window

<img width="1330" height="843" alt="image" src="https://github.com/user-attachments/assets/75618f57-b0c1-4841-b902-c5d74f0ee603" />


---

## Task Manager

<img width="1251" height="917" alt="image" src="https://github.com/user-attachments/assets/a3c4511d-a12f-4f9a-bbac-596b7c89f47f" />

---

## Quiz

<img width="1326" height="916" alt="image" src="https://github.com/user-attachments/assets/e39ea639-1be9-4e18-9069-9bfaa67e4946" />

---

## Activity Log

<img width="877" height="547" alt="image" src="https://github.com/user-attachments/assets/49193d02-6371-4860-8934-2c8e3b768626" />

---

# 🔄 Continuous Integration

GitHub Actions automatically:

- Builds the project
- Restores NuGet packages
- Checks for compilation errors

## Successful Workflow

> **Insert a screenshot of your successful GitHub Actions build here**

---

# 📦 Releases

Project releases are available under the **Releases** section of this repository.

Example:

- v1.0 - Part 1
- v2.0 - Part 2
- v3.0 - Final POE

---

# 📹 Demonstration Video

YouTube Presentation

```
https://youtu.be/7fCSc0EQ3jQ
```

---

# 👨‍💻 Author

**Luke Cowley**

Programming 2A (PROG6221)

The Independent Institute of Education

2026

---

# 📄 License

This project was developed for educational purposes as part of the Programming 2A Portfolio of Evidence.

Not intended for commercial use.

---

# ⭐ Acknowledgements

Special thanks to:

- The Independent Institute of Education
- Programming 2A Lecturers
- Microsoft (.NET)
- GitHub
