# Roblox Anti-AFK (VB .Net)

By Hevanafa, 7th May 2023

## How it works:
This app will beep 10 seconds before it activates the script.
The script will activate Roblox, press <kbd>Esc</kbd>, and then minimise it automatically.
The interval is 7 minutes, so you don't have to worry about getting kicked due to 20 minutes of being idle.

Keep in mind that there's still a tiny chance that Roblox will lag & doesn't register the keyboard event due to lag.

## How to Change the Sound
You can change the sound, but since I'm using the built-in .Net `SoundPlayer`, it only supports WAV files.

Simply change the `sound_file$` property in `Form1.vb`.
