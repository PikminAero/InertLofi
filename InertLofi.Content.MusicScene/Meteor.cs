using CalamityMod.Events;
using CalamityMod.NPCs.PlaguebringerGoliath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using InertLofi.Utils;

namespace InertLofi.InertLofi.Content.MusicScene
{
    public class MeteorScene : ModSceneEffect
    {
        public override int Music => MusicLoader.GetMusicSlot(InertLofiMod.Instance, "Assets/Music/Meteor");

        public override SceneEffectPriority Priority => SceneEffectPriority.Environment;
        public override float GetWeight(Player player)
        {
            return 1f;
        }

        public override bool IsSceneEffectActive(Player player)
        {
            return TileCounter.MeteoriteOre > 75 && !BossRushEvent.BossRushActive
            && ModContent.GetInstance<InertLofiConfig>().ReplaceMeteor
            && ModContent.GetInstance<InertLofiConfig>().ToggleAll;
        }
    }
}
