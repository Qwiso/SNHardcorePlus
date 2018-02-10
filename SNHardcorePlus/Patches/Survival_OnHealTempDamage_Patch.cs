using Harmony;
using System.Collections.Generic;
using System.Reflection.Emit;


namespace SNHardcorePlus.Patches
{
    [HarmonyPatch(typeof(Survival))]
    [HarmonyPatch("OnHealTempDamage")]
    public class Survival_OnHealTempDamage_Patch
    {
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            bool injected = false;

            foreach (CodeInstruction instruction in instructions)
            {
                if (instruction.opcode.Equals(OpCodes.Ldc_R4) && instruction.operand.Equals(200f) && !injected)
                {
                    injected = true;
                    var newInstruction = new CodeInstruction(OpCodes.Ldc_R4, HCPSettings.FoodMax);
                    newInstruction.labels = instruction.labels;
                    yield return newInstruction;
                }
                else
                {
                    yield return instruction;
                }
            }
        }
    }
}
