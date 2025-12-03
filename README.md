# Multi-Player Snake Game

A multiplayer Snake game based on TCP protocol, developed with C# and Windows Forms.

## 📋 Project Overview

This is a classic Snake game that supports multiple players playing simultaneously through TCP network connections.  The project adopts a Client-Server architecture and uses the SuperSimpleTcp library for network communication.

## 🎮 Game Features

- 🌐 Support for multiplayer online gameplay
- 🐍 Classic Snake game mechanics
- 🔄 Real-time synchronization of player movements
- 🖥️ Clean Windows Forms graphical interface
- 📡 Stable connection based on TCP protocol

## 🛠️ Technical Architecture

### Development Environment
- **Language**: C#
- **Framework**: .NET 6.0 (Windows)
- **UI**: Windows Forms
- **Network Library**: SuperSimpleTcp

### Project Structure
```
Muti-Player-Snake-Game/
├── Client/              # Client application
│   ├── Form1.cs        # Client main logic
│   └── Program.cs      # Client entry point
├── Server/              # Server application
│   ├── Form1.cs        # Server main logic
│   └── Program.cs      # Server entry point
└── ClientServer. sln    # Visual Studio solution file
```

## 🚀 Getting Started

### Requirements
- Windows 7 or higher
- .NET 6.0 Runtime
- Visual Studio 2022 (for development)

### Starting the Server
1. Open and run the `Server` project
2. The server will automatically detect the local IP address
3. Click the "Start" button to start the server
4. The server will listen on the specified IP and Port

### Starting the Client
1.  Open and run the `Client` project
2. Enter the server's IP address and Port
3. Enter a player name
4. Click the "Connect" button to connect to the server
5. Use arrow keys to control the snake's movement

## 🎯 Game Controls

- **↑ Up Arrow**: Move up
- **↓ Down Arrow**: Move down
- **← Left Arrow**: Move left
- **→ Right Arrow**: Move right

## 📡 Network Communication Protocol

### Packet Format
- Uses a simple string protocol
- Format: `[Command][Data]`
- Example: `k` + direction data (keyboard input)

### Key Features
- **Client Connection Management**: Automatically tracks connected and disconnected clients
- **Real-time Data Transfer**: Player movement commands sent to server in real-time
- **Position Updates**: Server receives and processes player position updates

## 🎨 Game Interface

### Client Interface
- 500x420 pixel game area
- Blue blocks represent the snake
- Red blocks represent food
- Each block size: 20x20 pixels

### Server Interface
- Display list of connected clients
- Real-time server status messages
- Start/Stop server controls

## 🔧 Core Functionality

### Client
- Connect to server
- Render game graphics
- Handle player input
- Send movement commands to server
- Update game state every 50ms

### Server
- Listen for client connections
- Manage multiple client connections
- Receive and process player movement data
- Broadcast game state updates
- Handle client disconnections

## 📦 Dependencies

- **SuperSimpleTcp**: Simplified TCP communication library

## 📝 Development Notes

The project is currently in development stage.  Some features are not yet fully implemented (such as complete game logic synchronization on the server side). 

## 👨‍💻 Author

[YuminChiang](https://github.com/YuminChiang)

## 📄 License

This project currently has no specified license. 

---

⭐ If you like this project, please give it a Star!
