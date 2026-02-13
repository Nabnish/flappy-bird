# Flappy Bird

A classic **Flappy Bird-style game** built in **Unity using C#**.  
This project replicates the simple yet addictive gameplay of the original *Flappy Bird* where you control a bird that must fly through gaps in moving pipes without crashing.

---

## 🎮 Gameplay

- Tap / Click to make the bird flap and fly up.
- The bird falls due to gravity when not flapping.
- Navigate through gaps between pipes to score points.
- Colliding with the pipes or ground results in **Game Over**.

---

## 📁 Project Structure

| File / Folder | Description |
|---------------|-------------|
| `birdscript.cs` | Controls bird movement, flapping, and physics |
| `pipespawnerscript.cs` | Handles spawning of pipe obstacles |
| `pipescript.cs` | Behavior of individual pipes |
| `logicmanager.cs` | Game logic (score, state transitions, restart) |
| `AntiCheat.cs` | (Optional) Anti-cheat / score protection logic |
| `.gitignore` | Git ignore rules |
| `.gitattributes` | Git attributes |

---

## 🚀 Features

✔ Unity C# implementation of Flappy Bird mechanics  
✔ Simple controls (tap / click to flap)  
✔ Obstacle spawning and movement  
✔ Basic scoring system  
✔ Easily extendable for new features (UI, sound, visuals)

---

## 🛠 Requirements

To run and edit this project you’ll need:

- **Unity (2020.3 LTS or newer)**  
- A modern web browser / emulator for builds  
- Basic familiarity with Unity Editor

---

## ▶️ How to Run

1. **Clone the repository**
   ```bash
   git clone https://github.com/Nabnish/flappy-bird.git
