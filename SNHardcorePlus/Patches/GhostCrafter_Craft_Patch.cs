using Harmony;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace SNHardcorePlus.Patches
{
    //[HarmonyPatch(typeof(GhostCrafter))]
    //[HarmonyPatch("Craft")]
    //class GhostCrafter_Craft_Patch
    //{
    //    public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
    //    {
    //        bool injected = false;

    //        foreach (var instruction in instructions)
    //        {
    //            if (instruction.opcode.Equals(OpCodes.Ldc_R4) && instruction.operand.Equals(5) && !injected)
    //            {
    //                injected = true;

    //                yield return new CodeInstruction(OpCodes.Ldc_R4, HCPSettings.Instance.PowerUsedPerCraft);
    //                continue;
    //            }

    //            yield return instruction;
    //        }
    //    }
    //}
}
