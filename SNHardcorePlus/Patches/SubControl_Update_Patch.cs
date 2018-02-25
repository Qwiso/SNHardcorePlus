using Harmony;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace SNHardcorePlus.Patches
{
    [HarmonyPatch(typeof(SubControl))]
    [HarmonyPatch("Update")]
    class SubControl_Update_Patch
    {
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            bool isInjected = false;

            foreach (var instruction in instructions)
            {
                yield return instruction;

                if (instruction.opcode.Equals(OpCodes.Stloc_1) && !isInjected)
                {
                    isInjected = true;

                    yield return new CodeInstruction(OpCodes.Ldloc_1);
                    yield return new CodeInstruction(OpCodes.Ldc_R4, HCPSettings.Instance.CyclopsMotorDrainMultiplier);
                    yield return new CodeInstruction(OpCodes.Mul);
                    yield return new CodeInstruction(OpCodes.Stloc_1);
                }
            }
        }
    }
}
