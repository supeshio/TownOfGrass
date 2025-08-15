using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

namespace TownOfGrass;

[BepInPlugin(PluginName, PluginName, PluginVersion)]
public class TOG : BasePlugin
{
    public const string Id = "supeshio.com.github";
    public const string PluginName = "TownOfGrass";
    public const string PluginVersion = "1.0.0";
    public Harmony Harmony = new(Id);
    internal new static ManualLogSource Logger;

    public override void Load()
    {
        // Plugin startup logic
        Logger = base.Log;
        Log.LogInfo($"{PluginName} is loaded!");
        //Harmony.PatchAll();
    }
}