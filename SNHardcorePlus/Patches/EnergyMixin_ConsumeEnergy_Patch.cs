using Harmony;
using System;

namespace SNHardcorePlus.Patches
{
    [HarmonyPatch(typeof(EnergyMixin))]
    [HarmonyPatch("ConsumeEnergy")]
    class EnergyMixin_ConsumeEnergy_Patch
    {
        public static bool Prefix(EnergyMixin __instance, bool __result, ref float amount)
        {
            float num = -__instance.ModifyCharge(-Math.Abs(amount * HCPSettings.Instance.HandToolsPowerDrainMultiplier));
            __result = num > 0f;
            return false;
        }
    }
}
