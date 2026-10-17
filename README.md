# MultiAppRPC

A lightweight background utility for Windows that automatically updates your Discord Rich Presence based on your active applications.

---
[Discord's Developer Portal](https://discord.com/developers/applications)

---

## Requirements

* **Windows 7+**
* **[.NET 8.0 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)**
* **[Discord](https://discord.com/channels/@me) Desktop Application** running locally.

---

## Installation & Setup

1. Download the [latest release](https://github.com/v4ish/RPC/releases/latest).
2. Extract all files to your desired installation directory.
3. Run `MultiAppRPC.exe`.

---

## Configuration (`appsettings.json`)

Automatically generated on first launch. Edit directly or via the built-in **Settings** window:

```json
[
  {
    "ProcessName": "TouchDesigner",
    "DiscordAppId": "12345676767676767",
    "LargeImageKey": "white",
    "DisplayName": "TouchDesigner",
    "ActivityVerb": "Editing"
  }
]

```

* **ProcessName:** Windows process name (without `.exe`).
* **DiscordAppId:** Discord Developer Application ID.
* **LargeImageKey:** Rich Presence Asset key.
* **DisplayName:**  what to show name.
* **ActivityVerb:** Action verb displayed in Discord (e.g., *Editing*, *Watching*, *Streaming*, *Listening*).

---
‎
| Application  | AppID | Assets  |
|----------|-------|--------|
| TouchDesigner   | `1555927073145487421`  | `black, white`     |
| DaVinci Resolve  | `1131090005872349215`   | `main`     |
| mpv    | `1560586298958413904`  | `mpv`     |
| VLC Media Player  | `1244968109299863554`   | `main, main-logo`     |
| QBittorrent    | `1131638268698566738`  | `logo-new`     |
| Spicetify    | `1132652587187982406`  | `main, main-logo`     |
| Waterfox    | `1131889146995154995`  | `main`     |
| Road 96    | `1546138009051725846`  | `road96`     |
| Counter-Strike 2    | `1409102557938454591`  | `cs2_logo, ak47, ct_logo, t_logo, de_dust2, de_inferno, de_mirage, timer`     |


### FAQ

#### .EXE file is not launching?

- Make sure you have dotnet 8.0 installed.
- Check Tray Menu

####  Having trouble or Want to request a new RPC?

- [Request a RPC by opening a issue](https://github.com/v4ish/RPC/labels/Request)
- [Join Discord](https://dsc.gg/v4ish)
