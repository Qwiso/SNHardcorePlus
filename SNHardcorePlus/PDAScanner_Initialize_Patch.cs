using Harmony;
using System.Collections.Generic;

namespace SNHardcorePlus.Patches
{
    [HarmonyPatch(typeof(PDAScanner))]
    [HarmonyPatch("GetEntryData")]
    class PDAScanner_GetEntryData_Patch
    {
        private static Dictionary<TechType, int> _requiredFragments = new Dictionary<TechType, int>()
        {
            { TechType.SeaglideFragment, 5 }
        };

        public static void Postfix(ref PDAScanner.EntryData __result, TechType key)
        {
            if (__result != null && HCPSettings.Instance.Blueprints.Required.ContainsKey(key))
            {
                __result.totalFragments = _requiredFragments[key];
            }
        }
    }
}
