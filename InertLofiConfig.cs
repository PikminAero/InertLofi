using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace InertLofi
{
    public class InertLofiConfig : ModConfig
    {

        public static InertLofiConfig Instance;
        public override ConfigScope Mode => ConfigScope.ClientSide;
        // Please try to keep those alphabetically ordered...
        [Header("GlobalToggle")]
        [DefaultValue(true)]
        public bool ToggleAll { get; set; }

        [Header("MusicToggles")]
        
        [DefaultValue(true)]
        public bool ReplaceAbyss1 { get; set; }
        [DefaultValue(true)]
        public bool ReplaceAbyss2 { get; set; }
        [DefaultValue(true)]
        public bool ReplaceAbyss4 { get; set; }
        [DefaultValue(true)]
        public bool ReplaceAquaticScourge { get; set; }
        [DefaultValue(true)]
        public bool ReplaceAstralSurface { get; set; }
        [DefaultValue(true)]
        public bool ReplaceAstralUnderground { get; set; }
        [DefaultValue(true)]
        public bool ReplaceAstrumAureus { get; set; }
        [DefaultValue(true)]
        public bool ReplaceAstrumDeus { get; set; }
        [DefaultValue(true)]
        public bool ReplaceBioLab { get; set; }
        [DefaultValue(true)]
        public bool ReplaceBrimCrag { get; set; }
        [DefaultValue(true)]
        public bool ReplaceBrimstoneElemental { get; set; }
        [DefaultValue(true)]
        public bool ReplaceBumblebirb { get; set; }
        [DefaultValue(true)]
        public bool ReplaceCalamitasPhase1 { get; set; }
        [DefaultValue(true)]
        public bool ReplaceCalamitasPhase2 { get; set; }
        [DefaultValue(true)]
        public bool ReplaceCalamitasPhase3 { get; set; }
        [DefaultValue(true)]
        public bool ReplaceCalamitasPhase4 { get; set; }
        [DefaultValue(true)]
        public bool ReplaceCalClone { get; set; }
        [DefaultValue(true)]
        public bool ReplaceCeaselessVoid { get; set; }
        [DefaultValue(true)]
        public bool ReplaceCrabulon { get; set; }
        [DefaultValue(true)]
        public bool ReplaceCryogen { get; set; }
        [DefaultValue(true)]
        public bool ReplaceDesertScourge { get; set; }
        [DefaultValue(true)]
        public bool ReplaceDoGPhase1 { get; set; }
        [DefaultValue(true)]
        public bool ReplaceDoGPhase2 { get; set; }
        [DefaultValue(true)]
        public bool ReplaceHiveMind { get; set; }        
        [DefaultValue(true)]
        public bool ReplaceLanternNight { get; set; }
        [DefaultValue(true)]
        public bool ReplaceLevi1 { get; set; }
        [DefaultValue(true)]
        public bool ReplaceLevi2 { get; set; }
        [DefaultValue(true)]
        public bool ReplaceLevi3 { get; set; }
        [DefaultValue(true)]
        public bool ReplaceOldDuke { get; set; }
        [DefaultValue(true)]
        public bool ReplacePerforators { get; set; }
        [DefaultValue(true)]
        public bool ReplacePlagueGoliath { get; set; }
        [DefaultValue(true)]
        public bool ReplacePlanetoid { get; set; }
        [DefaultValue(true)]
        public bool ReplacePolterGhast { get; set; }
        [DefaultValue(true)]
        public bool ReplaceProfanedGuardians { get; set; }
        [DefaultValue(true)]
        public bool ReplaceProvidence { get; set; }
        [DefaultValue(true)]
        public bool ReplaceRavager { get; set; }
        [DefaultValue(true)]
        public bool ReplaceSignus { get; set; }
        [DefaultValue(true)]
        public bool ReplaceSlimeGod { get; set; }
        [DefaultValue(true)]
        public bool ReplaceStormWeaver { get; set; }
        [DefaultValue(true)]
        public bool ReplaceSulphurSeaDay { get; set; }
        [DefaultValue(true)]
        public bool ReplaceSulphurSeaNight { get; set; }
        [DefaultValue(true)]
        public bool ReplaceSunkenSea { get; set; }
        [DefaultValue(true)]
        public bool ReplaceWyrm { get; set; }
        [DefaultValue(true)]
        public bool ReplaceYharon1 { get; set; }
        [DefaultValue(true)]
        public bool ReplaceYharon2 { get; set; }

    }
}
