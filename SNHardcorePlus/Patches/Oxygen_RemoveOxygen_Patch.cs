using Harmony;
using UnityEngine;

namespace SNHardcorePlus.Patches
{
    [HarmonyPatch(typeof(Oxygen))]
    [HarmonyPatch("RemoveOxygen")]
    class Oxygen_RemoveOxygen_Patch
    {
        public static bool Prefix(Oxygen __instance, float __result, ref float amount)
        {
            var cleanAmount = Mathf.Min(amount, __instance.oxygenAvailable);

            float num = Mathf.Min(amount * HCPSettings.Instance.OxygenDrainMultiplier, __instance.oxygenAvailable);

            __instance.oxygenAvailable = Mathf.Max(0f, __instance.oxygenAvailable - num);

            __result = cleanAmount;

            return false;
        }
    }
}
