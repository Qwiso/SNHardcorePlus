using System;
using System.Collections.Generic;
using Harmony;
using System.Reflection;
using UnityEngine;

namespace SNHardcorePlus.Patches
{
    [HarmonyPatch(typeof(Survival))]
    [HarmonyPatch("UpdateStats")]
    public class Survival_UpdateStats_Patch
    {
        public static bool Prefix(Survival __instance, ref float __result, ref float timePassed)
        {
            float num = 0f;

            if (timePassed > 1.401298E-45f)
            {
                float prevVal = __instance.food;
                float prevVal2 = __instance.water;

                float num2 = (timePassed / 2520f * 100f) * HCPSettings.Instance.FoodDrainMultiplier;
                if (num2 > __instance.food)
                {
                    num += (num2 - __instance.food) * HCPSettings.Instance.StarvationDamageMultiplier;
                }
                __instance.food = Mathf.Clamp(__instance.food - num2, 0f, HCPSettings.Instance.FoodMax);

                float num3 = (timePassed / 1800f * 100f) * HCPSettings.Instance.WaterDrainMultiplier;
                if (num3 > __instance.water)
                {
                    num += (num3 - __instance.water) * HCPSettings.Instance.DehydrationDamageMultiplier;
                }
                __instance.water = Mathf.Clamp(__instance.water - num3, 0f, HCPSettings.Instance.WaterMax);

                MethodInfo warningSoundsMethod = __instance.GetType().GetMethod("UpdateWarningSounds", BindingFlags.NonPublic | BindingFlags.Instance);
                warningSoundsMethod.Invoke(__instance, new object[] { __instance.foodWarningSounds, __instance.food, prevVal, HCPSettings.Instance.FoodMax * 0.2f, HCPSettings.Instance.FoodMax * 0.1f });
                warningSoundsMethod.Invoke(__instance, new object[] { __instance.waterWarningSounds, __instance.water, prevVal, HCPSettings.Instance.WaterMax * 0.2f, HCPSettings.Instance.WaterMax * 0.1f });
            }

            __result = num;

            return false;
        }
    }
}
