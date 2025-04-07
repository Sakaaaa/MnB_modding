using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;


namespace AccelerateGrowth
{
    public class SubModuleSettings : AttributeGlobalSettings<SubModuleSettings>
    {

        [SettingPropertyFloatingInteger("Growth Rate", 0f, 100f, "0.0", Order = 0, RequireRestart = false, HintText = "Adjusts the rate at which all children grow.")]
        [SettingPropertyGroup("Children Growth Rate Settings")]
        // works instantly
        public float newGrowthRate { get; set; } = 1f;

        [SettingPropertyFloatingInteger("Adjust Pregnancy Duration", 1f, 36f, Order = 2, RequireRestart = false, HintText = "Adjust the number of days it takes for children to be born.")]
        [SettingPropertyGroup("Pregnancy Duration")]
        // works instantly
        public float AdjsutPregnancyDuration { get; set; } = 36f;

        [SettingPropertyFloatingInteger("XP Gain Rate", 1f, 100f, "0.0", Order = 0, RequireRestart = false, HintText = "Adjusts the rate at which XP gained.")]
        [SettingPropertyGroup("XP Gain Rate Settings")]
        public float newXPRate { get; set; } = 1f;


        [SettingPropertyInteger("Maximum Additional Alley Count", minValue: 0, maxValue: 30, Order = 2, RequireRestart = false, HintText = "Adjusts maximum number of alleys.")]
        [SettingPropertyGroup("Maximum Alley Count Settings")]
        // works instantly
        public int MaximumAlleyCount { get; set; } = 0;

        public override string Id => "AccelerateGrowth";
        // DisplayName in mod config menu
        public override string DisplayName => "AccelerateGrowth Settings";
        public override string FolderName => "AccelerateGrowth";
        public override string FormatType => "xml";
    }
}