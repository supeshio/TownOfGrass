using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

namespace TownOfGrass
{
    [HarmonyPatch(typeof(VersionShower),nameof(VersionShower.Start))]
    public static class ShowModName
    {
        public static void Postfix(VersionShower __instance)
        {
            TextMeshPro text = new GameObject("TOG").AddComponent<TextMeshPro>();
            text.text = $"<color=#00ff7f>{TOG.PluginName} v{TOG.PluginVersion}";
            text.transform.SetParent(__instance.transform);
            text.transform.localPosition = Vector3.zero;
            text.transform.localScale = Vector3.one;
            text.alignment = TextAlignmentOptions.Right;
            text.fontSize = text.fontSizeMin = text.fontSizeMax = 2f;
            text.enableWordWrapping = false;

        }
    }
}
