using Harmony;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;

namespace SNHardcorePlus.Patches
{
    [HarmonyPatch(typeof(Survival))]
    [HarmonyPatch("UpdateHunger")]
    public class Survival_UpdateHunger_Patch
    {
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            bool healthThresholdInjected = false;
            bool healthRegenAmountInjected = false;

            foreach (CodeInstruction instruction in instructions)
            {
                if (instruction.opcode.Equals(OpCodes.Ldc_R4) && instruction.operand.Equals(150f) && !healthThresholdInjected)
                {
                    healthThresholdInjected = true;

                    yield return new CodeInstruction(OpCodes.Ldc_R4, (HCPSettings.FoodMax + HCPSettings.WaterMax) * HCPSettings.HealthRegenerationThreshold);
                    continue;
                }

                if (instruction.opcode.Equals(OpCodes.Ldc_R4) && Mathf.Approximately(0.04166667f, (float)instruction.operand) && !healthRegenAmountInjected)
                {
                    healthRegenAmountInjected = true;

                    yield return new CodeInstruction(OpCodes.Ldc_R4, (HCPSettings.HealthRegenerationAmount / 10f));
                    continue;
                }

                yield return instruction;
            }
        }
    }
}
