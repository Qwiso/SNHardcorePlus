using Harmony;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace SNHardcorePlus.Patches
{
    [HarmonyPatch(typeof(GrowingPlant))]
    [HarmonyPatch("GetGrowthDuration")]
    class GrowingPlant_GetGrowthDuration_Patch
    {
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            bool multiplierInjected = false;

            foreach (var instruction in instructions)
            {
                if (instruction.opcode.Equals(OpCodes.Ldloc_0) && !multiplierInjected)
                {
                    multiplierInjected = true;
                    yield return new CodeInstruction(OpCodes.Ldc_R4, (1f / HCPSettings.Instance.PlantGrowRateMultiplier));
                    continue;
                }

                yield return instruction;
            }
        }
    }
}
