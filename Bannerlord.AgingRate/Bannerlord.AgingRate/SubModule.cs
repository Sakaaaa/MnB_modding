using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.ComponentInterfaces;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using TaleWorlds.MountAndBlade;
using TaleWorlds.CampaignSystem.GameComponents;
using System.Linq;
using System;
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using HarmonyLib;
using MCM.Abstractions.Base.Global;



namespace Bannerlord.AgingRate
{
    public class SubModule : MBSubModuleBase
    {
        private Harmony _harmony;
        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();
            _harmony = new Harmony("Bannerlord.AgingRate");
            _harmony.PatchAll();
            InformationManager.DisplayMessage(new InformationMessage("AgingRate loaded succesfully.", Colors.Green));

        }

        protected override void OnSubModuleUnloaded()
        {
            base.OnSubModuleUnloaded();

        }

        protected override void OnBeforeInitialModuleScreenSetAsRoot()
        {
            base.OnBeforeInitialModuleScreenSetAsRoot();

        }

        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            base.OnGameStart(game, gameStarterObject);
            if (game.GameType is Campaign)
            {
                CampaignEvents.DailyTickEvent.AddNonSerializedListener(this, DailyTick);
            }

        }


        private void DailyTick()
        {
            applyGrowthRateToPlayerChildren();
        }


        private void applyGrowthRateToPlayerChildren()
        {
            // float growthRate = GlobalSettings<SubModuleSettings>.Instance.newGrowthRate;
            float growthRate = 15f;
            foreach (Hero h in Hero.AllAliveHeroes)
            {
                if (h.IsChild && h.Age < 18 && (h.Clan == Hero.MainHero.Clan))
                {
                    h.SetBirthDay(h.BirthDay - CampaignTime.Days(growthRate + 1f)); // +1f triples growth rate essentially
                }
            }
        }
    }

}
