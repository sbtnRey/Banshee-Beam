# Banshee-Beam-VR

A simple VR sound visualizer/projectile component that spawns and changes the properties of a projectile (currently only color gradient) based on the pitch of ones voice. Curently the range of frequencies is only set to capture and utilize the human voice and the color gradient used is from red(low frequencies) to yellow(high frequencies). Future improvements on this codebase would be to integrate the component into a game.


## Build instructions
Built using Unity 2018.3.11

### Prerequisites
* HTC Vive (HardWare)
* [Unity 2017.1.0](https://unity3d.com/unity/whats-new/2018.3.11)
* [SteamVR Plugin](https://assetstore.unity.com/packages/templates/systems/steamvr-plugin-32647)

### Additional Sources Used
* [Pitch Detector Plugin](https://github.com/tbriley/PitchDetector)

## Author

**Sebastian Reynolds**

Contact: **sxr@pdx.edu**

## What doesn't work 
One major probalem that I suspected from the start that I would run into it the latency/lag between when one makes a sound and when an actual projectile is spawned. the lag isn't too bad, but I think that this can be resolved be being a little more tricker about how I'm curretly calling spawn objects. When a single object is called for the projectile rather than multiple, there doesn't seem to be any lag.

Another problem That I would like to resolve is that I could not utilize my VR headsets internal microphone for my current build, rather use a seperate one.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details

## Demo
[Gameplay demo of current state](https://www.youtube.com/watch?v=DZXe3aoYR50)

