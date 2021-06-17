using HarmonyLib;
using System.Collections.Generic;
using System.Reflection.Emit;
using static PulsarPluginLoader.Patches.HarmonyHelpers;

namespace CustomContentTests.Components.PolytechModule
{
    class DragonModule : PulsarPluginLoader.Content.Components.PolytechModule.PolytechModulePlugin
    {
        public override string Name => "P.T. Module: Mass Annihilator";

        public override string Description => "1.7x Power output while equiped\n<color=red>Warning: This component constantly consumes hull integrity. Not recommended for extended use</color>";

        public override void Tick(PLShipComponent InComp)
        {
            InComp.ShipStats.Ship.MyHull.Current -= 0.01f;
            InComp.ShipStats.HullCurrent -= 0.01f;
        }
    }
    [HarmonyPatch(typeof(PLReactor), "ShipUpdate")]
    class PLReactorShipUpdatePatch
    {
        static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            List<CodeInstruction> targetSequence = new List<CodeInstruction>()
            {
                new CodeInstruction(OpCodes.Br_S),
                new CodeInstruction(OpCodes.Ldloca_S),
                new CodeInstruction(OpCodes.Call),
                new CodeInstruction(OpCodes.Stloc_S),
                new CodeInstruction(OpCodes.Ldloc_S),
                new CodeInstruction(OpCodes.Brfalse_S),
                new CodeInstruction(OpCodes.Ldloc_S),
                new CodeInstruction(OpCodes.Callvirt),
                new CodeInstruction(OpCodes.Brfalse_S),

            };
            List<CodeInstruction> injectedSequence = new List<CodeInstruction>()
            {
                new CodeInstruction(OpCodes.Ldarg_0),
                new CodeInstruction(OpCodes.Ldloc_S, 10),
                new CodeInstruction(OpCodes.Call, AccessTools.Method(typeof(PLReactorShipUpdatePatch), "PatchMethod")),
            };

            return PatchBySequence(instructions, targetSequence, injectedSequence, patchMode: PatchMode.AFTER, checkMode: CheckMode.NONNULL);
        }
        public static void PatchMethod(PLShipInfoBase inShipInfo, PLPoweredShipComponent plpoweredShipComponent)
        {
            if (plpoweredShipComponent.ActualSlotType == ESlotType.E_COMP_POLYTECH_MODULE && plpoweredShipComponent.SubType == PulsarPluginLoader.Content.Components.PolytechModule.PolytechModulePluginManager.Instance.GetPolytechModuleIDFromName("P.T. Module: Mass Annihilator"))
            {
                inShipInfo.MyStats.ReactorBoostedOutputMax *= 1.7f;
            }
        }
    }
}
