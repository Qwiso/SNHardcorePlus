using Harmony;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace SNHardcorePlus.Patches
{
    [HarmonyPatch(typeof(AttachToVehicle))]
    [HarmonyPatch("ConsumeEnergy")]
    class AttachToVehicle_ConsumeEnergy_Patch
    {
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            bool isInjected = false;

            foreach (var instruction in instructions)
            {
                if (instruction.opcode.Equals(OpCodes.Ldfld) && !isInjected)
                {
                    isInjected = true;

                    yield return new CodeInstruction(OpCodes.Ldc_R4, HCPSettings.Instance.LavaLarvaPowerDrain);
                    continue;
                }

                yield return instruction;
            }
        }
    }
}
