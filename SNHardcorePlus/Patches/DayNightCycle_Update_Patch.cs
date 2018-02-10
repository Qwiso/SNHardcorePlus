using Harmony;

namespace SNHardcorePlus.Patches
{
    [HarmonyPatch(typeof(DayNightCycle))]
    [HarmonyPatch("Update")]
    class DayNightCycle_Update_Patch
    {
        public static bool Prefix(DayNightCycle __instance)
        {
            if (__instance.debugFreeze) return false;

            var speed = __instance.GetType().GetField("_dayNightSpeed", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            speed.SetValue(__instance, HCPSettings.DayNightCycleMultiplier);

            __instance.timePassedAsDouble += (double)__instance.deltaTime;

            var updateAtmosphereMethod = __instance.GetType().GetMethod("UpdateAtmosphere", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var updateDayNightMessage = __instance.GetType().GetMethod("UpdateDatNightMessage", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

            updateAtmosphereMethod.Invoke(__instance, new object[] { });
            updateDayNightMessage.Invoke(__instance, new object[] { });

            return false;
        }
    }
}
