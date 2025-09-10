using System;
using System.Runtime.CompilerServices;

namespace TownOfGrass
{
    public static class Logger
    {
        public static void Info(string text, string tag = "", [CallerMemberName] string callerMethod = "") => TOG.Log.LogInfo($"[{tag}:Info][{DateTime.Now}][{callerMethod}]{text}");

        public static void Warning(string text, string tag = "", [CallerMemberName] string callerMethod = "") => TOG.Log.LogWarning($"[{tag}:Warning][{DateTime.Now}][{callerMethod}]{text}");

        public static void Error(string text, string tag = "", [CallerMemberName] string callerMethod = "") => TOG.Log.LogError($"[{tag}:Error][{DateTime.Now}][{callerMethod}]{text}");

        public static void Fatel(string text, string tag = "", [CallerMemberName] string callerMethod = "") => TOG.Log.LogFatal($"[{tag}:Fatel][{DateTime.Now}][{callerMethod}]{text}");

        public static void Message(string text, string tag = "", [CallerMemberName] string callerMethod = "") => TOG.Log.LogMessage($"[{tag}][{DateTime.Now}][{callerMethod}]{text}");
    }
}