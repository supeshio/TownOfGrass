using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

namespace TownOfGrass
{

    [BepInPlugin(Id, PluginName, PluginVersion)]
    public class TOG : BasePlugin
    {
        public const string Id = "supeshio.com.github";
        public const string PluginName = "TownOfGrass";
        public const string PluginVersion = "1.0.0";
        public Harmony Harmony = new(Id);
        internal new static ManualLogSource Log;

        public override void Load()
        {
            // Plugin startup logic
            Log = base.Log;
            Log.LogInfo($"{PluginName} is loaded!");
            Harmony.PatchAll();
        }
    }
}
