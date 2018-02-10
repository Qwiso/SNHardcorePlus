using Harmony;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace SNHardcorePlus.Patches
{
    [HarmonyPatch(typeof(Survival))]
    [HarmonyPatch("Eat")]
    class Survival_Eat_Patch
    {
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            bool hungryValueInjected = false;
            bool foodInjected = false;
            bool waterInjected = false;

            foreach (var instruction in instructions)
            {
                if (instruction.opcode.Equals(OpCodes.Ldc_R4) && instruction.operand.Equals(99f) && !hungryValueInjected)
                {
                    hungryValueInjected = true;

                    var newInstruction = new CodeInstruction(OpCodes.Ldc_R4, HCPSettings.FoodMax - 1f);
                    newInstruction.labels = instruction.labels;
                    yield return newInstruction;
                    continue;
                }

                if (instruction.opcode.Equals(OpCodes.Ldc_R4) && instruction.operand.Equals(200f) && !foodInjected)
                {
                    foodInjected = true;

                    var newInstruction = new CodeInstruction(OpCodes.Ldc_R4, HCPSettings.FoodMax);
                    newInstruction.labels = instruction.labels;
                    yield return newInstruction;
                    continue;
                }

                if (instruction.opcode.Equals(OpCodes.Ldc_R4) && instruction.operand.Equals(100f) && !waterInjected)
                {
                    waterInjected = true;

                    var newInstruction = new CodeInstruction(OpCodes.Ldc_R4, HCPSettings.WaterMax);
                    newInstruction.labels = instruction.labels;
                    yield return newInstruction;
                    continue;
                }

                yield return instruction;
            }
        }
    }
}
