using Harmony;

namespace SNHardcorePlus.Patches
{
    [HarmonyPatch(typeof(PDAScanner))]
    [HarmonyPatch("GetEntryData")]
    class PDAScanner_GetEntryData_Patch
    {
        public static void Postfix(ref PDAScanner.EntryData __result, TechType key)
        {
            if (__result != null && HCPSettings.Instance.ScannerData.Required.ContainsKey(key))
            {
                __result.totalFragments = HCPSettings.Instance.ScannerData.Required[key];
            }
        }
    }
}
