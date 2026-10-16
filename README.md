# MultiAppRPC

A lightweight background utility for Windows that automatically updates your Discord Rich Presence based on your active applications.

---

## Features

* **Automatic Detection:** Dynamically switches Discord RPC status when supported apps run.
* **Dynamic Activity Tracking:** Displays custom verbs and active window/file titles.
* **System Tray Control:** Runs in the background with full tray management.
* **GUI Configuration:** Manage monitored apps via a built-in settings window.
* **Auto-Update & Startup:** Optional Windows startup persistence and GitHub release checks.

---

## Requirements

* **Windows 7+**
* **.NET 8.0 Runtime**
* **Discord Desktop Application** running locally.

---

## Installation & Setup

1. Download the latest release archive from the releases page.
2. Extract all files to your desired installation directory.
3. Place an `app.ico` file in the folder (optional; uses system fallback if missing).
4. Run `MultiAppRPC.exe`.

---

## Configuration (`appsettings.json`)

Automatically generated on first launch. Edit directly or via the built-in **Settings** window:

```json
[
  {
    "ProcessName": "TouchDesigner",
    "DiscordAppId": "YOUR_DISCORD_APP_ID",
    "LargeImageKey": "white",
    "DisplayName": "TouchDesigner",
    "ActivityVerb": "Editing"
  }
]

```

* **ProcessName:** Windows process name (without `.exe`).
* **DiscordAppId:** Discord Developer Client ID.
* **LargeImageKey:** Rich Presence Asset key.
* **DisplayName:**  what to show name.
* **ActivityVerb:** Action verb displayed in Discord (e.g., *Editing*, *Watching*, *Streaming*, *Listening*).

---
‎

### FAQ

#### .EXE file is not launching?

- Make sure you have dotnet 8.0 installed.
- Check Tray Menu

####  Having trouble or Want to request a new RPC?

- [Request a RPC by opening a issue](https://github.com/v4ish/RPC/labels/Request)
- [Join Discord](https://dsc.gg/v4ish)
