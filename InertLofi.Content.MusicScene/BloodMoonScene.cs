using CalamityMod.Events;
using CalamityMod.NPCs.HiveMind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;
using System.Security.AccessControl;
using Terraria.GameContent.Events;

namespace InertLofi.InertLofi.Content.MusicScene
{
    public class BloodMoonScene : ModSceneEffect
    {
        public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/BloodMoon");

        public override SceneEffectPriority Priority => SceneEffectPriority.Event;

        public override bool IsSceneEffectActive(Player player)
        {
            return Main.bloodMoon && (player.ZoneOverworldHeight || player.ZoneSkyHeight) && !BossRushEvent.BossRushActive
            && ModContent.GetInstance<InertLofiConfig>().ReplaceBloodMoon
            && ModContent.GetInstance<InertLofiConfig>().ToggleAll;
        }
    }
}
