
using TaleWorlds.CampaignSystem.GameComponents;
using HarmonyLib;
using JetBrains.Annotations;
using MCM.Abstractions.Base.Global;
using TaleWorlds.CampaignSystem;
using System.Collections.Generic;
using System.Reflection.Emit;
using System;
using MCM.Common;


namespace AccelerateGrowth
{
    [HarmonyPatch(typeof(DefaultPregnancyModel), nameof(DefaultPregnancyModel.PregnancyDurationInDays), MethodType.Getter)]
    public static class AdjustPregnancyDuration
    {
        [UsedImplicitly]
        [HarmonyPostfix]
        public static void Postfix(ref float __result)
        {

            __result = GlobalSettings<SubModuleSettings>.Instance.AdjsutPregnancyDuration;
        }
    }

    [HarmonyPatch(typeof(DefaultAlleyModel), nameof(DefaultAlleyModel.MaximumTroopCountInPlayerOwnedAlley), MethodType.Getter)]
    public static class AdjustTroopCountInPlayerOwnedAlley
    {

        public static void Postfix(ref int __result)
        {
            __result = __result + GlobalSettings<SubModuleSettings>.Instance.MaximumAlleyCount;
        }
    }


    [HarmonyPatch(typeof(DefaultGenericXpModel), nameof(DefaultGenericXpModel.GetXpMultiplier))]
    public static class AdjustGenericXpRatio
    {

        public static void Postfix(ref float __result)
        {
            __result = __result * GlobalSettings<SubModuleSettings>.Instance.newXPRate;
        }
    }

    // use either this way, but unable to change XP gained rate by config
    //[HarmonyPatch(typeof(DefaultCombatXpModel), nameof(DefaultCombatXpModel.GetXpFromHit))]
    //public static class AdjustXpFromHit
    //{

    //    static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
    //    {

    //        var found = false;
    //        var get_ResultNumber = AccessTools.Method(typeof(ExplainedNumber), "get_ResultNumber");
    //        //float newXPRate = GlobalSettings<SubModuleSettings>.Instance.newXPRate;
    //        float newXPRate = 10f;

    //        foreach (var instruction in instructions)
    //        {
    //            yield return instruction;
    //            if (instruction.opcode == OpCodes.Call && instruction.operand == get_ResultNumber)
    //            {
    //                yield return new CodeInstruction(OpCodes.Ldc_R4, newXPRate);
    //                yield return new CodeInstruction(OpCodes.Mul, null);
    //                found = true;
    //            }

    //        }
    //        if (found is false)
    //            throw new ArgumentException("Cannot find ExplainedNumber::get_ResultNumber");
    //    }

    //}

}