using Harmony;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace SNHardcorePlus.Patches
{
    [HarmonyPatch(typeof(CrafterLogic))]
    [HarmonyPatch("ConsumeEnergy")]
    class CrafterLogic_ConsumeEnergy_Patch
    {
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            foreach (var instruction in instructions)
            {
                if (instruction.opcode.Equals(OpCodes.Ldarg_1))
                {
                    yield return new CodeInstruction(OpCodes.Ldc_R4, HCPSettings.Instance.PowerUsedPerCraft);
                    continue;
                }

                yield return instruction;
            }
        }
    }
}
