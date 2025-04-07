using TaleWorlds.CampaignSystem.GameComponents;
using HarmonyLib;
using JetBrains.Annotations;

namespace Bannerlord.AgingRate
{
    [HarmonyPatch(typeof(DefaultPregnancyModel), nameof(DefaultPregnancyModel.PregnancyDurationInDays), MethodType.Getter)]
    public static class AdjustPregnancyDuration
    {
        [UsedImplicitly]
        [HarmonyPostfix]
        public static void Postfix(ref float __result)
        {

            __result = 3;
        }
    }

    [HarmonyPatch(typeof(DefaultAlleyModel), nameof(DefaultAlleyModel.MaximumTroopCountInPlayerOwnedAlley), MethodType.Getter)]
    public static class AdjustTroopCountInPlayerOwnedAlley
    {

        public static void Postfix(ref int __result)
        {
            __result = __result * 2;
        }
    }

    //// this affects too many aspects 
    //[HarmonyPatch(typeof(PerkObject), nameof(PerkObject.PrimaryBonus), MethodType.Getter)]
    //public static class AdjustPerkExp
    //{

    //    public static void Postfix(ref float __result)
    //    {
    //        __result = __result * 10;
    //    }
    //}
}