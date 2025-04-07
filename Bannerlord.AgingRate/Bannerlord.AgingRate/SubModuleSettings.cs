//using MCM.Abstractions.Attributes;
//using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;


namespace Bannerlord.AgingRate
{
    public class SubModuleSettings : AttributeGlobalSettings<SubModuleSettings>
    {

        //[SettingPropertyFloatingInteger("Growth Rate", 0f, 40f, "0.0", Order = 0, RequireRestart = false, HintText = "Adjusts the rate at which all children grow.")]
        //[SettingPropertyGroup("Children Growth Rate Settings")]
        //public float newGrowthRate { get; set; } = 15f;
        public float newGrowthRate = 15f;

        //[SettingPropertyFloatingInteger("Adjust Pregnancy Duration", 1f, 36f, Order = 2, RequireRestart = false, HintText = "Adjust the number of days it takes for children to be born.")]
        //[SettingPropertyGroup("Pregnancy Duration")]
        //public float AdjsutPregnancyDuration { get; set; } = 36f;

        //[SettingPropertyFloatingInteger("XP Gain Rate", 1f, 100f, "0.0", Order = 0, RequireRestart = false, HintText = "Adjusts the rate at which XP gained.")]
        //[SettingPropertyGroup("XP Gain Rate Settings")]
        //public float newXPRate { get; set; } = 10f;

        //[SettingPropertyInteger("Maximum Alley Count", minValue: 10, maxValue: 30, Order = 2, RequireRestart = false, HintText = "Adjusts maximum number of alleys.")]
        //[SettingPropertyGroup("Maximum Alley Count Settings")]
        //public int MaximumAlleyCount { get; set; } = 10;

        public override string Id => "Bannerlord.AgingRate";
        public override string DisplayName => "Children Grow Faster and Hero gain more XP";
        public override string FolderName => "AgingRate";
        public override string FormatType => "xml";
    }
}