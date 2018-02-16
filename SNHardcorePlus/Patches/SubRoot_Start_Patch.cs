using Harmony;

namespace SNHardcorePlus.Patches
{
    [HarmonyPatch(typeof(SubRoot))]
    [HarmonyPatch("Awake")]
    class SubRoot_Start_Patch
    {
        public static void Prefix(SubRoot __instance)
        {
            __instance.shieldPowerCost = HCPSettings.Instance.CyclopsShieldPowerCost;
            __instance.sonarPowerCost = HCPSettings.Instance.CyclopsSonarPowerCost;
            __instance.silentRunningPowerCost = HCPSettings.Instance.CyclopsSilentPowerCost;
        }
    }
}
