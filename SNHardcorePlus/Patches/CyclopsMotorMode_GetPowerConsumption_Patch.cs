using Harmony;

namespace SNHardcorePlus.Patches
{
    [HarmonyPatch(typeof(CyclopsMotorMode))]
    [HarmonyPatch("GetPowerConsumption")]
    class CyclopsMotorMode_GetPowerConsumption_Patch
    {
        public static void Postfix(ref float __result)
        {
            __result = __result * HCPSettings.Instance.CyclopsMotorPowerDrainMultiplier;
        }
    }
}
