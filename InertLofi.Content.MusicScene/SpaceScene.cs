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
    public class SpaceScene : ModSceneEffect
    {
        public override int Music => MusicLoader.GetMusicSlot((Mod)(object)InertLofiMod.Instance, "Assets/Music/Space");

        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;

        public override bool IsSceneEffectActive(Player player)
        {
            return player.ZoneNormalSpace && !BossRushEvent.BossRushActive
            && ModContent.GetInstance<InertLofiConfig>().ReplaceSpace
            && ModContent.GetInstance<InertLofiConfig>().ToggleAll;
        }
    }
}
