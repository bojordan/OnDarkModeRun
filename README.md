# OnDarkModeRun
A simple Windows system tray application to run commands when a switch between dark mode and light mode is made.

Until there is a configuration UI, simply edit the `appsettings.json` file to include the commands you would like run:

``` json
{
  "Settings": {
    "OnDarkModeCommands": [
      {
        "CommandFileName": "C:\\Program Files\\Rainmeter\\Rainmeter.exe",
        "Args": "!LoadLayout \"CPU RAM clocks big monitor\""
      }
    ],
    "OnLightModeCommands": [
      {
        "CommandFileName": "C:\\Program Files\\Rainmeter\\Rainmeter.exe",
        "Args": "!LoadLayout \"CPU RAM clocks big monitor light\""
      }
    ]
  }
}
```

# License
This application is available under the MIT License.

# Icon
Icon file: https://icon-icons.com/icon/moon/48261, from Cheat Sheet icons https://icon-icons.com/pack/Cheat-Sheet-icons/494
Free version of https://linearicons.com/
Created by https://perxis.com/
Licensed under CC BY-SA 4.0 (Creative Commons Attribution-ShareAlike 4.0 International)
https://creativecommons.org/licenses/by-sa/4.0/
