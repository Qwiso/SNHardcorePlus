using Harmony;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace SNHardcorePlus.Patches
{
    [HarmonyPatch(typeof(uGUI_FoodBar))]
    [HarmonyPatch("LateUpdate")]
    public class uGUI_FoodBar_Patch
    {
        public static IEnumerable<CodeInstruction> Transpiler(MethodBase original, ILGenerator generator, IEnumerable<CodeInstruction> instructions)
        {
            bool injected = false;

            foreach (CodeInstruction instruction in instructions)
            {
                if (instruction.opcode.Equals(OpCodes.Ldc_R4) && !injected)
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
