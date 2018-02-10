using Harmony;

namespace SNHardcorePlus.Patches
{
    [HarmonyPatch(typeof(DamageSystem))]
    [HarmonyPatch("CalculateDamage")]
    class DamageSystem_CalculateDamage_Patch
    {
        public static void Postfix(float __result)
        {
            __result *= HCPSettings.RawDamageMultiplier;
        }
    }
}
