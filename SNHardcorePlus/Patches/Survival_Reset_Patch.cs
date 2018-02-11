using Harmony;

namespace SNHardcorePlus.Patches
{
    [HarmonyPatch(typeof(Survival))]
    [HarmonyPatch("Reset")]
    class Survival_Reset_Patch
    {
        public static bool Prefix(Survival __instance)
        {
            __instance.GetComponent<Player>().liveMixin.data.maxHealth = HCPSettings.Instance.HealthMax;
            __instance.GetComponent<Player>().liveMixin.health = HCPSettings.Instance.HealthMax * HCPSettings.Instance.HealthRespawnRatio;

            __instance.food = HCPSettings.Instance.FoodStart;
            __instance.water = HCPSettings.Instance.WaterStart;

            return false;
        }
    }
}
