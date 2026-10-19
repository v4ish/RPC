
# MultiAppRPC


A tiny Windows System Tray app that automatically flexes what you're doing on Discord Rich Presence. Set it up once, Forget that you set it up, and let it do its thing.

Made with ❤️
## 🖥️ Interface Overview

```text
┌───────────────────────────────────────────────────────────────────────────────────────┐
│                 MULTI-APP DISCORD RPC WATCHER (v1.1.0) - UI OVERVIEW                 │
└───────────────────────────────────────────────────────────────────────────────────────┘

  SYSTEM TRAY MENU                                   MAIN SETTINGS CONFIGURATION WINDOW
┌───────────────────────────┐       ┌───────────────────────────────────────────────────────────────────────┐
│ Status: Active (Firefox)  │       │ MultiAppRPC Settings                                        [─][□][✕] │
│ [✓] Enable RPC Service    │       ├───────────────────────────────────────────────────────────────────────┤
│ [ ] Global Private Mode   │       │ Enabled │ Private │ Display Name   │ Process Name (.exe) │ Verb         │
├───────────────────────────┤       ├─────────┼─────────┼────────────────┼────────────────────┼──────────────┤
│ Settings...  ─────────────┼──────>│   [✓]   │   [ ]   │ TouchDesigner  │ TouchDesigner      │ Editing      │
│ Start with Windows        │       │   [✓]   │   [ ]   │ DaVinci Resolve│ Resolve            │ Editing      │
│ Check for Updates...      │       │   [✓]   │   [🔒]  │ mpv            │ mpv                │ Watching     │
│ Help / About              │       │   [✓]   │   [🔒]  │ VLC Media Player│ VLC              │ Watching     │
├───────────────────────────┤       │   [✓]   │   [ ]   │ Counter-Strike 2│ cs2              │ Playing      │
│ Exit                      │       │   [✓]   │   [🔒]  │ qBittorrent    │ qbittorrent        │ Managing     │
└───────────────────────────┘       │   [✓]   │   [🔒]  │ Firefox        │ firefox            │ Browsing     │
                                    │   [✓]   │   [ ]   │ Spicetify      | spotify            │ Listening to │
                                    ├───────────────────────────────────────────────────────────────────────┤
                                    │ [ Add ] [ Delete ]  [ Move Up ] [ Move Down ]  [ Load JSON ] [ Export ]│
                                    │                                                                       │
                                    │ [✓] Enable RPC Service   [ ] Global Private Mode  [✓] Start with Win  │
                                    │                                       ┌──────────────┐ ┌────────────┐ │
                                    │                                       │ Save & Apply │ │   Cancel   │ │
                                    └───────────────────────────────────────┴──────────────┴─┴────────────┴─┘

```

---


## 🚀 Quickstart

1. Grab the [.NET 8.0 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/8.0).
2. Download the [latest release](https://github.com/v4ish/RPC/releases/latest) and extract the files.
3. Run `MultiAppRPC.exe` — it'll live in your system tray.

---

## ⚙️ Configuration (`appsettings.json`)

Created automatically when you first launch the app. Edit the config file manually or just use the built-in Settings UI:

```json
[
  {
    "IsEnabled": true,
    "IsPrivate": false,
    "ProcessName": "TouchDesigner",
    "DiscordAppId": "12345676767676767",
    "LargeImageKey": "white",
    "DisplayName": "TouchDesigner",
    "ActivityVerb": "Editing"
  }
]

```

* **ProcessName:** Executable name (without `.exe`).
* **DiscordAppId:** Your Discord Developer App ID.
* **LargeImageKey:** Asset key configured in your Discord portal.
* **DisplayName:** The app name shown on your profile.
* **ActivityVerb:** Custom status verb (*Editing*, *Watching*, *Listening*, *Playing*).


---



## 🎯 Pre-configured Apps

<details>
  <summary><i>Click me.</i></summary>
 

Works right out of the box with these presets:
 <b>

| Application | AppID | Assets |
| --- | --- | --- |
| **TouchDesigner** | `1555927073145487421` | `black`, `white` |
| **DaVinci Resolve** | `1131090005872349215` | `main` |
| **mpv** | `1560586298958413904` | `mpv` |
| **VLC Media Player** | `1244968109299863554` | `main`, `main-logo` |
| **qBittorrent** | `1131638268698566738` | `logo-new` |
| **Spicetify** | `1132652587187982406` | `main`, `main-logo` |
| **Waterfox** | `1131889146995154995` | `main` |
| **Road 96** | `1546138009051725846` | `road96` |
| **Counter-Strike 2** | `1409102557938454591` | `cs2_logo`, `ak47`, `ct_logo`, `t_logo`, `de_dust2`, `de_inferno`, `de_mirage`, `timer` |
| **Windows Terminal** | `1560925252303855626` | `cls` |
| **Steam** | `1560935090476023848` | `steam` |
| **Firefox** | `1560942734129365123` | `firefox` |
</b>
</details>

---

## 💬 Community & Support

* **Not starting up?** Make sure [.NET 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) is installed and check your system tray menu icons.
* **Missing an app?** [Open an RPC Request](https://github.com/v4ish/RPC/labels/Request) or hop into our [Discord Community](https://dsc.gg/v4ish)!
