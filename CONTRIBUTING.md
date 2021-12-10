# Contributing

Contributions really really really are welcome!
If you want to go the extra mile though, there's a few things that'd be appreciated.

If you would like to discuss VRC modding in general, join the [VRChat Modding Group Discord](https://discord.gg/rCqKSvR).
Since this project is not big enough to warrant it's own discord server as of writing.

## Getting started with modding

If you're a bit new to modding, you should probably read the [MelonLoader Wiki modders pages](https://melonwiki.xyz/#/modders/quickstart).

Here's the basic process for getting started though:

1. Run VRChat with the latest MelonLoader at least once so that it generates the required files
2. Clone this repository or your fork of it
3. Make sure that dotnet build finds the references correctly
   - A standard VRC installation path should just work
   - A folder called `VRChat` can be symlinked under the cloned repository, or the required files can be copied to said folder
   - `VRChatPath` can be edited in the `Directory.Build.props` file with the correct local path
4. Build the mod(s)
   - Visual Studio can be used to add the .sln project file and then just build using the UI
   - Command line can be used to create a release build that doesn't automatically copy all the mods to your VRC directory with `CopyModFiles=false dotnet build -c Release VRC-Mods.sln`
   - Another example of command line usage is `dotnet build VRChatUtilityKit/VRChatUtilityKit.csproj` which builds VRCUK and copies the result to your `$(VRChatPath)mods` folder automatically
5. Edit the source code & build the mod
6. Relaunch VRC after having copied the mod DLL file to the mods folder to test the changes
7. Once you get your changes working, you could create a pull request!

## PR checklist

It'd be appreciated if you:

- Formatted the code in a way that matches the existing style (4 spaces).
- Split big changes into many small & easy to understand commits

## Getting Github org access

Ping or message @ljoonal.
Access will be given to almost anyone with some track record of modding that is interested in helping out.
After you've been added to the org, you can create your own branch or edit other branches.
The `main` branch has been protected to require reviewed PR's though.
