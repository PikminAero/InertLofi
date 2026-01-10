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
    public class CavernsScene : ModSceneEffect
    {
        public override int Music => MusicLoader.GetMusicSlot(InertLofiMod.Instance, "Assets/Music/Caverns");

        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;

        public override bool IsSceneEffectActive(Player player)
        {
            return player.ZoneNormalCaverns && !BossRushEvent.BossRushActive
            && ModContent.GetInstance<InertLofiConfig>().ReplaceCaverns
            && ModContent.GetInstance<InertLofiConfig>().ToggleAll;
        }
    }
}
