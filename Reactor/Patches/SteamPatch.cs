using System.IO;

namespace Reactor.Patches
{
    internal static class SteamPatch
    {
        public static void Initialize()
        {
            const string file = "steam_appid.txt";

            if (!File.Exists(file))
            {
                File.WriteAllText(file, "945360");
            }
        }
    }
}
