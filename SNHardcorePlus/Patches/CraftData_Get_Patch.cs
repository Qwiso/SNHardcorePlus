using Harmony;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace SNHardcorePlus.Patches
{
    [HarmonyPatch(typeof(CraftData))]
    [HarmonyPatch("Get")]
    class CraftData_Get_Patch
    {
        public static readonly Type TechDataType = typeof(CraftData).GetNestedType("TechData", BindingFlags.NonPublic);

        public static void Postfix(ref ITechData __result, ref TechType techType)
        {
            var patchedTech = HCPTechData.GetFromTechData(__result);

            for (int i = 0; i < patchedTech.ingredientCount; i++)
            {
                patchedTech._ingredients[i] = new HCPIngredient(patchedTech._ingredients[i].techType, patchedTech._ingredients[i].amount * HCPSettings.Instance.CraftingCostMultiplier);
            }

            __result = patchedTech;
        }
    }
}
