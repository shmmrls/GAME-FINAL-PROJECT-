# Click the Target

![Language](https://img.shields.io/badge/language-VB.NET-512BD4?logo=dotnet&logoColor=white)
![Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4)
![Type](https://img.shields.io/badge/type-Windows%20Forms%20game-lightgrey)
![Platform](https://img.shields.io/badge/platform-Windows-0078D6)

A fast-paced **arcade-style reflex game** built with VB.NET and Windows Forms. Click the target
as it jumps around the screen, build up your score before time runs out, and try to beat your
high score across three difficulty levels.

<p align="center">
  <img src="Resources/CLICK%20THE%20TARGET.png" alt="Click the Target home screen" width="500">
</p>

---

## Table of Contents

- [Gameplay](#gameplay)
- [Features](#features)
- [Tech Stack](#tech-stack)
- [Getting Started](#getting-started)
- [Technical Highlights](#technical-highlights)
- [Project Structure](#project-structure)
- [Known Limitations and Roadmap](#known-limitations-and-roadmap)
- [Author](#author)
- [License](#license)

## Gameplay

1. From the home screen, click **Play** and choose a difficulty: **Easy**, **Medium**, or **Hard**.
2. Click the start button to begin the round. A countdown timer starts and the target appears.
3. Click the target to score points. Each hit moves it to a new random position.
4. Click anywhere else and you lose a point (your score never drops below zero).
5. When time runs out, your final score is shown. Beat your best to set a **new high score**,
   then replay the level or return to the home screen.

Harder levels give you less time to score.

| Difficulty | Starting timer value |
|------------|----------------------|
| Easy | 100 |
| Medium | 75 |
| Hard | 50 |

## Features

- **Three difficulty levels** with different time limits
- **Score system** with a point penalty for missed clicks
- **Persistent high score** saved between sessions using application settings
- **Click feedback:** the target briefly shrinks when hit
- **Low-time warning:** the timer turns red during the last stretch of a round
- **Sound effects** for starting the game, hitting the target, missing, and game over
- **Multi-screen navigation:** home, difficulty select, about, game, and play-again screens
- **Custom artwork** for the title screen, buttons, and backgrounds

## Tech Stack

| Layer | Technology |
|-------|------------|
| Language | Visual Basic .NET |
| UI | Windows Forms (.NET Framework 4.7.2) |
| Audio | `My.Computer.Audio` (WAV files) |
| Persistence | `My.Settings` (user-scoped `HighScore` setting) |
| IDE | Visual Studio 2022 |

## Getting Started

### Prerequisites

- Windows with **Visual Studio 2022** (the *.NET desktop development* workload)
- **.NET Framework 4.7.2** developer pack

### Run the project

```bash
git clone https://github.com/shmmrls/click-the-target-game.git
cd click-the-target-game
```

1. Open `GAME (FINAL PROJECT).sln` in Visual Studio.
2. Press **F5** to build and run.

The sound effects in the `Resources` folder are copied next to the executable automatically
when you build, so no extra setup is needed.

## Technical Highlights

- **Event-driven game loop:** a `Timer` control drives the countdown, while mouse click events
  on the target and the form handle scoring and penalties.
- **Hit detection:** clicks on the form are checked against the target's bounds
  (`PictureBox.Bounds.Contains`) to distinguish hits from misses.
- **Random target placement:** the target is repositioned within the form's client area using
  `Random`, so it always stays on screen.
- **Asynchronous feedback:** `Async`/`Await` with `Task.Delay` creates the target's brief
  shrink effect without freezing the UI.
- **Centralized audio helper:** all sound playback goes through one `PlaySound` method
  (`Sounds.vb`) that resolves files relative to the application folder and fails silently
  if a file is missing, so audio problems can never crash the game.
- **Persistent state:** the high score is stored with `My.Settings` and saved when beaten.
- **Multi-form navigation:** screens are separate forms that show and hide one another to
  create a complete game flow.

## Project Structure

```text
click-the-target-game/
├── Form1.vb                   # Home screen (class: Home): Play and About
├── CHOOSE.vb                  # Difficulty selection screen
├── EASY.vb / MEDIUM.vb / HARD.vb       # Game screens, one per difficulty
├── PLAYAGAIN.vb, MEDAGAINN.vb, HARDAGAIN.vb   # Play-again screens after a round
├── ABOUT.vb                   # About screen
├── Sounds.vb                  # Shared audio helper (PlaySound)
├── Resources/                 # Images and sound effects
├── My Project/                # Application settings (including HighScore)
├── GAME (FINAL PROJECT).sln   # Visual Studio solution
└── README.md
```

## Known Limitations and Roadmap

This project was built as a final course project. Planned improvements:

- [ ] **Reduce duplication:** the three game screens share nearly identical code. A single game
      form that accepts difficulty settings (time limit, speed) would replace three copies
- [ ] Connect the unused **Thank You** screen to the game flow (or remove it)
- [ ] **Track a separate high score per difficulty** (currently one score is shared)
- [ ] **Show the high score on all game screens**
- [ ] Review the combo and timer logic and tune the difficulty balance
- [ ] Rename forms and controls to descriptive names (for example, `btnPlay` instead of
      `PictureBox1`)
- [ ] Add a **screenshots** section with gameplay captures

## Author

**Trisha Mia Morales**
GitHub: [@shmmrls](https://github.com/shmmrls)

## License

No license has been specified for this project yet. Add a `LICENSE` file (for example,
[MIT](https://choosealicense.com/licenses/mit/)) if you want others to reuse the code.
