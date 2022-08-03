_Utilities for Boneworks speedrunning._

# Features

- Speedrun mode
  - Enabling this mode will disable practice features and temporarily alter the save state so that a run will meet the leaderboard submission rules
  - There are three modes depending on what type of speedrun you are performing:
    - Normal
      - Activate with CTRL + S or by pressing A + B on both controllers
      - In this mode the save state will be reset every time you leave the main menu and start a new game
    - Newgame+
      - Activate with CTRL + N
      - In this mode the save state will be updated to have everything unlocked
    - 100%
      - Activate with CTRL + H
      - In this mode the save state will be reset only when initially enabled
  - Deactivate any mode with any of the activation hotkeys while in the main menu
  - Preferences like height and turn settings are maintained through save state resets and loads
  - Deactivate speedrun mode to restore your original save state
  - You must disable all other mods before enabling any speedrun mode
  - You can tell that a speedrun mode is enabled based on the text added to the loading screen (Steam game version only)
    - Includes mod version and approximate run time to make splicing harder (don't worry if the time does not match LiveSplit exactly)
- Make boss claw always patrol to the area near the finish in Streets
  - Boss claw cabin appears _green_ when this feature is on, so that you're aware RNG is being manipulated
- Teleport to a chosen location to practice parts of a level again
  - Pressing B on both controllers at the same time sets the teleport point to the position you are currently standing at
  - Clicking the right controller thumbstick teleports you to the set point
  - Clicking A and B on the left controller at the same time resets the level
    - Useful for situations like in Museum when you teleport back to retry valve flying and need the valve to be back at its starting location
- Blindfold (Steam game version only)
  - For practicing and performing blindfolded runs
  - To blindfold yourself, press CTRL + B on the keyboard (game window must be focused)
    - If you do this during the main menu it will activate "blindfolded speedrun mode" where it will reset your save each time before starting a new game
  - This will make the VR headset display pitch black but the game window will still show the game (for spectating or to see where you are while practicing)

# Installation

- Make sure [Melon Loader](https://melonwiki.xyz/#/?id=what-is-melonloader) is installed in Boneworks
- Download [the SpeedrunTools mod from Thunderstore](https://boneworks.thunderstore.io/package/jakzo/SpeedrunTools/) (click on "Manual Download")
- Open the downloaded `.zip` file and extract `Mods/SpeedrunTools.dll` into `BONEWORKS/Mods/SpeedrunTools.dll`
  - You can usually find your `BONEWORKS` directory at `C:\Program Files (x86)\Steam\steamapps\common\BONEWORKS\BONEWORKS`

# Configuration

You can change some things (like where the boss claw moves to) by using MelonPreferencesManager:

- Install [MelonPreferencesManager](https://github.com/sinai-dev/MelonPreferencesManager) (download the IL2CPP version)
- Open the menu in-game using F5 to change config options

Most settings require restarting the level to take effect.

# Links

- Repository: https://github.com/jakzo/BoneworksSpeedrunTools
- Thunderstore: https://boneworks.thunderstore.io/package/jakzo/SpeedrunTools/
- How I reverse engineer the game: https://jakzo.github.io/BoneworksSpeedrunTools/
