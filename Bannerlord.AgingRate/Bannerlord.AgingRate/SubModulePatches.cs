using System;
using TaleWorlds.CampaignSystem.GameComponents;
using HarmonyLib;
using JetBrains.Annotations;
using TaleWorlds.MountAndBlade;
// using MCM.Abstractions.Base.Global;
using TaleWorlds.Library;
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using MCM.Abstractions.Base.Global;

namespace Bannerlord.AgingRate
{
    //[HarmonyPatch(typeof(DefaultPregnancyModel), nameof(DefaultPregnancyModel.PregnancyDurationInDays), MethodType.Getter)]
    //public static class AdjustPregnancyDuration
    //{
    //    [UsedImplicitly]
    //    [HarmonyPostfix]
    //    public static void Postfix(ref float __result)
    //    {

    //        __result = GlobalSettings<SubModuleSettings>.Instance.AdjsutPregnancyDuration;
    //    }
    //}

    //[HarmonyPatch(typeof(DefaultAlleyModel), nameof(DefaultAlleyModel.MaximumTroopCountInPlayerOwnedAlley), MethodType.Getter)]
    //public static class AdjustTroopCountInPlayerOwnedAlley
    //{

    //    public static void Postfix(ref int __result)
    //    {
    //        __result = GlobalSettings<SubModuleSettings>.Instance.MaximumAlleyCount;
    //    }
    //}


    //[HarmonyPatch(typeof(PerkObject), nameof(PerkObject.PrimaryBonus), MethodType.Getter)]
    //public static class AdjustPerkExp
    //{

    //    public static void Postfix(ref float __result)
    //    {
    //        __result = __result * GlobalSettings<SubModuleSettings>.Instance.newXPRate;
    //    }
    //}
}