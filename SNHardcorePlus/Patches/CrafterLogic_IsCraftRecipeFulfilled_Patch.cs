using Harmony;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace SNHardcorePlus.Patches
{
    [HarmonyPatch(typeof(CrafterLogic))]
    [HarmonyPatch("IsCraftRecipeFulfilled")]
    class CrafterLogic_IsCraftRecipeFulfilled_Patch
    {
        public static readonly object targetOperand = typeof(IIngredient).GetMethod("get_amount", BindingFlags.Public | BindingFlags.Instance);

        public static IEnumerable<CodeInstruction> Transpiler(MethodBase original, ILGenerator generator, IEnumerable<CodeInstruction> instructions)
        {
            bool injected = false;

            foreach (var instruction in instructions)
            {
                yield return instruction;

                if (instruction.opcode.Equals(OpCodes.Callvirt) && instruction.operand.Equals(targetOperand) && !injected)
                {
                    injected = true;
                    yield return new CodeInstruction(OpCodes.Ldc_I4, HCPSettings.CraftingCostMultiplier);
                    yield return new CodeInstruction(OpCodes.Mul);
                }
            }
        }
    }
}
