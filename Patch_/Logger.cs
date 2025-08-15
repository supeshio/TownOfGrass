using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TownOfGrass
{
    public static class Logger
    {

        public static void Info(string text, string tag = "", [CallerMemberName] string callerMethod = "") => TOG.Logger.LogInfo($"[{tag}:Info][{DateTime.Now}][{callerMethod}]{text}");
        public static void Warning(string text, string tag = "", [CallerMemberName] string callerMethod = "") => TOG.Logger.LogWarning($"[{tag}:Warning][{DateTime.Now}][{callerMethod}]{text}");
        public static void Error(string text, string tag = "", [CallerMemberName] string callerMethod = "") => TOG.Logger.LogError($"[{tag}:Error][{DateTime.Now}][{callerMethod}]{text}");
        public static void Fatel(string text, string tag = "", [CallerMemberName] string callerMethod = "") => TOG.Logger.LogFatal($"[{tag}:Fatel][{DateTime.Now}][{callerMethod}]{text}");
        public static void Message(string text, string tag = "", [CallerMemberName] string callerMethod = "") => TOG.Logger.LogMessage($"[{tag}][{DateTime.Now}][{callerMethod}]{text}");

    }

}
