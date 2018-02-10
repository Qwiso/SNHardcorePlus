using Harmony;
using System.Reflection;

namespace SNHardcorePlus
{
    public static class Patcher
    {
        public static void Patch()
        {
            HarmonyInstance harmony = HarmonyInstance.Create("com.snhardcoreplus.mod");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
