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
    public class RainScene : ModSceneEffect
    {
        public override int Music => MusicLoader.GetMusicSlot(InertLofiMod.Instance, "Assets/Music/Rain");

        public override SceneEffectPriority Priority => SceneEffectPriority.Environment;

        public override bool IsSceneEffectActive(Player player)
        {
            return Main.IsItRaining && (player.ZoneOverworldHeight || player.ZoneSkyHeight) && !BossRushEvent.BossRushActive
            && ModContent.GetInstance<InertLofiConfig>().ReplaceRain
            && ModContent.GetInstance<InertLofiConfig>().ToggleAll;
        }
    }
}
