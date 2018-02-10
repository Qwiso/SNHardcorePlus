using Harmony;

namespace SNHardcorePlus.Patches
{
    [HarmonyPatch(typeof(Survival))]
    [HarmonyPatch("Reset")]
    class Survival_Reset_Patch
    {
        public static bool Prefix(Survival __instance)
        {
            __instance.GetComponent<Player>().liveMixin.data.maxHealth = HCPSettings.HealthMax;
            __instance.GetComponent<Player>().liveMixin.health = HCPSettings.HealthMax * HCPSettings.HealthRespawnRatio;

            __instance.food = HCPSettings.FoodStart;
            __instance.water = HCPSettings.WaterStart;

            return false;
        }
    }
}
