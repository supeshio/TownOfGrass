using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using UnityEngine;

namespace TownOfGrass
{
    [HarmonyPatch(typeof(ChatController))]
    public static class ChatCommand
    {
        [HarmonyPatch(nameof(ChatController.SendChat)), HarmonyPrefix]
        public static bool SendChat(ChatController __instance)
        {
            return Chat(__instance);
        }

        public static bool Chat(ChatController __instance)
        {
            string chattext = __instance.freeChatField.textArea.text;
            if (chattext == null) return true;

            if (chattext.StartsWith("/"))
            {
                string[] texts = chattext.Split(" ");
                string addchat = "";
                string rpcaddchat = "";
                switch (texts[0])
                {
                    case "/version":
                    case "/ver":
                    case "/v":
                        addchat += $"version = {TOG.PluginVersion}";
                        break;
                }
                if (addchat != "")
                {
                    PlayerControl pc = PlayerControl.LocalPlayer;
                    string name = pc.Data.PlayerName;
                    pc.SetName($"<size=120%><color=#00ff7f>{TOG.PluginName}");
                    __instance.AddChat(pc, ($"<size=90%>{addchat}</size>"));
                    pc.SetName(name);
                    __instance.freeChatField.Clear();
                }
                if (rpcaddchat != "")
                {
                    PlayerControl pc = PlayerControl.LocalPlayer;
                    string name = pc.Data.PlayerName;
                    pc.RpcSetName($"<size=120%><color=#00ff7f>{TOG.PluginName}");
                    pc.RpcSendChat($"<size=90%>{rpcaddchat}</size>");
                    pc.RpcSetName(name);
                    __instance.freeChatField.Clear();
                }
                return false;
            }
            return true;
        }

        [HarmonyPatch(typeof(HudManager), nameof(HudManager.Update)), HarmonyPostfix]
        public static void HudStart(HudManager __instance)
        {
            if (__instance.Chat.isActiveAndEnabled) return;
            if (AmongUsClient.Instance.NetworkMode == NetworkModes.FreePlay)
            {
                __instance.Chat.SetVisible(true);
            }
        }
    }
}