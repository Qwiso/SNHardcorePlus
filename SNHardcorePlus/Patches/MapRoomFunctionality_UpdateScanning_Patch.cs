using Harmony;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace SNHardcorePlus.Patches
{
    [HarmonyPatch(typeof(MapRoomFunctionality))]
    [HarmonyPatch("UpdateScanning")]
    class MapRoomFunctionality_UpdateScanning_Patch
    {
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            bool isInjected = false;

            foreach (var instruction in instructions)
            {
                if (instruction.opcode.Equals(OpCodes.Ldc_R4) && instruction.operand.Equals(0.5f) && !isInjected)
                {
                    isInjected = true;
                    yield return new CodeInstruction(OpCodes.Ldc_R4, HCPSettings.Instance.MaproomPowerDrainMultiplier);
                    continue;
                }

                yield return instruction;
            }
        }
    }
}
