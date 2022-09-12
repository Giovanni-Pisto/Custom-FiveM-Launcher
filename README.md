# FiveM Custom Launcher

This is a custom Launcher for any FiveM server. You can connect your discord server and Team Speak. It always shows the status of the server if it is online or offline and the current number of players who are playing. In the general settings you can choose if start the Launcher when your computer starts or minimize the Launcher when it is closed.


## Getting Started

These instructions will allow you to make full use of the launcher's features

### Prerequisites 

Here's what you need:

* FiveM Server

* Discord Server

* Team Speak Server

* A Web site


# Setup
## Make sure you have .NET Framework 4.7.2 installed
1. Open the .sln file then go to Main.cs and edit those variables:
   - Line 21 public string ipSRV = "ip:30120"; (don't remove the :30120)
   - Line 22 public string DiscordLink = "https://discord.gg/Q2chWQ94bX";
   - Line 23 public string ts3IP = "";

2. Run the project, clicking in the green play button

3. And you're done.

### You can create a setup file for your launcher, or distribute the .exe file + Newtonsoft.Json.dll files located in Launcher > bin > debug, always include the Newtonsoft.Json.dll file!

##### This Launcher was build for NightLife Server (IT).

